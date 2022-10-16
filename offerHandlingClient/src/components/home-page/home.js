import ko from "knockout";
import homeTemplate from "text!./home.html";

class HomeViewModel {
  constructor(route) {
    var self = this;
    this.message = ko.observable("Welcome to offerHandling!");
    this.companies = ko.observableArray([]);

    $.ajax({
      type: "GET",
      url: "./home/index",
      dataType: "json",
      success: function (data) {
        data.forEach(function (company) {
          this.companies.push(company);
        }, self);
        //if(self.customers().length == 1)
        //{
        //    self.selectedCustomer(self.customers()[0]);
        //    self.showCustomerSelect(false);
        //}
      },
      error: function () {
        console.log("getCustomers Failed!!");
      },
    });
  }

  doSomething() {
    this.message("You invoked doSomething() on the viewmodel.");
  }
}

export default { viewModel: HomeViewModel, template: homeTemplate };
