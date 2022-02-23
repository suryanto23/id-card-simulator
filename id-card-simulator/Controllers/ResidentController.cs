using id_card_simulator.Database;
using id_card_simulator.Models;
using id_card_simulator.Models.PostModels;
using id_card_simulator.Models.PutModels;
using id_card_simulator.Models.DeleteModels;
using Microsoft.AspNetCore.Mvc;

namespace id_card_simulator.Controllers
{
    public class ResidentController : Controller
    {

        private IndexContext _context;
        private IWebHostEnvironment _hostEnv;

        public ResidentController(IndexContext source, IWebHostEnvironment hostEnv)
        {
            _context = source;
            _hostEnv = hostEnv;
        }
        public IActionResult Index()
        {
            return View(_context.Residents.ToList());
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
        public IActionResult CreateResident()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateResident(PostResident model)
        {
            // NIN Generator
            Random random = new Random();
            string NinPrefix = random.Next(100000, 999999).ToString();            
            string NinRoot = model.DateOfBirth.ToString("ddMMy");
            string NinSuffix = random.Next(1001, 9999).ToString();
            string generatedNin = NinPrefix + NinRoot + NinSuffix;

            // Image Upload
            string rootEnv = _hostEnv.WebRootPath;
            string imageFileExt = Path.GetExtension(model.ImageFile.FileName);
            string imageFileName = generatedNin + imageFileExt;
            string[] allowedExt = { ".jpg", ".jpeg", ".png" };

            if (allowedExt.Any(imageFileExt.ToLower().Contains))
            {
                string path = Path.Combine(rootEnv + "/assets/images/photos/" + imageFileName);
                using(var fileStream = new FileStream(path, FileMode.Create))
                {
                    await model.ImageFile.CopyToAsync(fileStream);
                }
            }
            else
            {
                ViewBag.InvalidExt = $"Invalid file extension: {imageFileExt} file is not allowed. Please upload a valid image either of jpg, jpeg, or png extension";
                return View();
            }            

            // Database Map and Post
            ResidentModel resident = new ResidentModel();

            resident.Nin = generatedNin;
            resident.IssuedDate = DateTime.Today.Date;
            resident.FullName = model.FullName;
            resident.DateOfBirth = model.DateOfBirth;
            resident.PlaceOfBirth = model.PlaceOfBirth;
            resident.Gender = model.Gender;
            resident.Address = model.Address;
            resident.City = model.City;
            resident.Province = model.Province;
            resident.Neighborhood = model.Neighborhood;
            resident.Hamlet = model.Hamlet;
            resident.UrbanDistrict = model.UrbanDistrict;
            resident.SubDistrict = model.SubDistrict;
            resident.BloodType = model.BloodType;
            resident.Religion = model.Religion;
            resident.MarriedStatus = model.MarriedStatus;
            resident.Profession = model.Profession;
            resident.Nationality = model.Nationality;
            resident.Image = imageFileName;

            _context.Residents.Add(resident);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateResident(Guid id)
        {
            ResidentModel resident = _context.Residents.Where(item => item.Id == id).FirstOrDefault();
            if(resident != null)
            {
                ViewBag.InvalidExt = TempData["InvalidExt"];
                return View(resident);
            }
            else
            {
                return RedirectToAction("PageNotFound");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateResident(PutResident model)
        {
            ResidentModel resident = _context.Residents.Where(item => item.Id == model.Id).FirstOrDefault();
            if (resident != null)
            {
                resident.FullName = model.FullName;
                resident.DateOfBirth = model.DateOfBirth;
                resident.PlaceOfBirth = model.PlaceOfBirth;
                resident.Gender = model.Gender;
                resident.Address = model.Address;
                resident.City = model.City;
                resident.Province = model.Province;
                resident.Neighborhood = model.Neighborhood;
                resident.Hamlet = model.Hamlet;
                resident.UrbanDistrict = model.UrbanDistrict;
                resident.SubDistrict = model.SubDistrict;
                resident.BloodType = model.BloodType;
                resident.Religion = model.Religion;
                resident.MarriedStatus = model.MarriedStatus;
                resident.Profession = model.Profession;
                resident.Nationality = model.Nationality;

                // Image replace
                if (model.ImageFile != null)
                {
                    string rootEnv = _hostEnv.WebRootPath;
                    string imageFileExt = Path.GetExtension(model.ImageFile.FileName);
                    string imageFileName = resident.Nin + imageFileExt;
                    string[] allowedExt = { ".jpg", ".jpeg", ".png" };

                    if (allowedExt.Any(imageFileExt.ToLower().Contains))
                    {
                        string path = Path.Combine(rootEnv + "/assets/images/photos/" + imageFileName);

                        FileInfo oldImage = new FileInfo(path);
                        if (oldImage.Exists) oldImage.Delete();

                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await model.ImageFile.CopyToAsync(fileStream);
                        }
                    }
                    else
                    {
                        TempData["InvalidExt"] = $"Invalid file extension: {imageFileExt} file is not allowed. Please upload a valid image either of jpg, jpeg, or png extension";
                        return RedirectToAction("UpdateResident" , model.Id);                        
                    }                   

                    resident.Image = imageFileName;
                }

                _context.Residents.Update(resident);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult DeleteResident(DeleteResident model)
        {
            ResidentModel resident = _context.Residents.Where(item => item.Id == model.id).FirstOrDefault();
            if (resident != null)
            {
                string rootEnv = _hostEnv.WebRootPath;
                string path = Path.Combine(rootEnv + "/assets/images/photos/" + resident.Image);

                FileInfo oldImage = new FileInfo(path);
                if (oldImage.Exists) oldImage.Delete();

                _context.Residents.Remove(resident);
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }

        public IActionResult Idcard(Guid id)
        {
            ResidentModel resident = _context.Residents.Where(item => item.Id == id).FirstOrDefault();
            if (resident != null)
            {
                return View(resident);
            }
            else
            {
                return RedirectToAction("PageNotFound");
            }
        }


    }
}
