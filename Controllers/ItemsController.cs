[HttpGet("/items/{id}")]
       public ActionResult Details(int id)
       {
           Item item = Item.Find(id);
           return View(item);
       }
