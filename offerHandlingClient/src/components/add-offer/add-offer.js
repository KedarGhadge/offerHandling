import ko from "knockout";
import templateMarkup from "text!./add-offer.html";

var company = function (
  cname,
  rounds,
  AppliedDate,
  responseDate,
  results,
  packageMin,
  packageMax,
  Scheduled,
  interviewDAte,
  condition,
  response,
  website
) {
  this.cname = cname;
  this.rounds = rounds;
  this.AppliedDate = AppliedDate;
  this.responseDate = responseDate;
  this.results = results;
  this.packageMin = packageMin;
  this.packageMax = packageMax;
  this.Scheduled = Scheduled;
  this.interviewDAte = interviewDAte;
  this.condition = condition;
  this.response = response;
  this.website = website;
};

var location = function (locationName, subLocationName) {
  this.locationName = locationName;
  this.subLocationName = subLocationName;
};

var contactPerson = function (contactPersonName, contactNumber) {
  this.contactPersonName = contactPersonName;
  this.contactNumber = contactNumber;
};

var tag = function (tagName) {
  this.tagName = tagName;
};
class Addoffer {
  constructor(params) {
    this.message = ko.observable("Hello from the addOffer component!");
    this.cname = ko.observable();
    this.rounds = ko.observable();
    this.locationName = ko.observable();
    this.subLocationName = ko.observable();
    this.AppliedDate = ko.observable();
    this.tagName = ko.observable();
    this.responseDate = ko.observable();
    this.results = ko.observable();
    this.packageMin = ko.observable();
    this.packageMax = ko.observable();
    this.Scheduled = ko.observable();
    this.interviewDAte = ko.observable();
    this.condition = ko.observable();
    this.response = ko.observable();
    this.contactPersonName = ko.observable();
    this.contactNumber = ko.observable();
    this.website = ko.observable();

    this.registerCompany = function () {
      alert("Hello");
      $.ajax({
        type: "POST",
        url: "./home/addCompany",
        data: ko.toJSON({
          cn: new company(
            this.cname(),
            this.rounds(),
            this.AppliedDate(),
            this.responseDate(),
            this.results(),
            this.packageMin(),
            this.packageMax(),
            this.Scheduled(),
            this.interviewDAte(),
            this.condition(),
            this.response(),
            this.website()
          ),
          ln: new location(this.locationName(), this.subLocationName()),
          cp: new contactPerson(this.contactPersonName(), this.contactNumber()),
          tg: new tag(this.tagName()),
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
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
    };
  }

  dispose() {
    // This runs when the component is torn down. Put here any logic necessary to clean up,
    // for example cancelling setTimeouts or disposing Knockout subscriptions/computeds.
  }
}

export default { viewModel: Addoffer, template: templateMarkup };
