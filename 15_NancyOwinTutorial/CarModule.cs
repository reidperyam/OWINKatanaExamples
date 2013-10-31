using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;

namespace NancyOwinTutorial
{
    public class CarModule : NancyModule
    {
        private readonly ICarRepository _repository;

        // this is a simple demonstration of constructor injection using Nancy's default injection...
        public CarModule(ICarRepository repository)
        {
            _repository = repository;

            Get["/"] = _ => "Hello World! Navigate to /car/id or /make/model to use wired-up functionality.";
            Get["/car/{id}"] = parameters =>
            {
                int id = parameters.id;
                var carModel = _repository.GetById(id);

                //return Negotiate
                //.WithStatusCode(HttpStatusCode.OK)
                //.WithModel(carModel);

                return Response.AsXml<Car>(carModel);
            };
            Get["/{make}/{model}"] = parameters =>
            {
                var carQuery = this.Bind<BrowseCarQuery>();
                var listOfCars = _repository.GetListOf(carQuery);

                //return Negotiate
                //.WithStatusCode(HttpStatusCode.OK)
                //.WithModel(listOfCars);

                return Response.AsXml<IList<Car>>(listOfCars);
            };
        }

    }
}