using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoLProject.Models;
using LoLProject.Common;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LoLProject.Controllers
{
    public class ChampionController : AsyncController
    {

        private ChampionDBContext db = new ChampionDBContext();
        //
        // GET: /Champion/
        public ActionResult Index()
        {
            //Champion c = new Champion();
            //ApiCall();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Champion model)
        {
            if (ModelState.IsValid)
            {
                // Create Champion Model
                try
                {
                    db.Champions.Add(model);
                    db.SaveChangesAsync();
                    return RedirectToAction("Index", "Champion");
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        public async void ApiCall()
        {
            var client = new HttpClient();
            string j = "/api/lol/static-data/na/v1.2/champion?champData=stats&api_key=a9ed50ee-5eae-42d6-bbe5-06a12f5b594f";
            client.BaseAddress = new Uri("https://prod.api.pvp.net");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(j);
            if (response.IsSuccessStatusCode)
            {
                var i = response.Content.ReadAsStringAsync();
                Console.WriteLine(i);
            }
        }
	}
}