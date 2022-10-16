import ko from "knockout";
import templateMarkup from "text!./add-offer.html";

class Addoffer {
  constructor(params) {
    this.message = ko.observable("Hello from the addOffer component!");
    this.comname = ko.observable();
    this.loct = ko.observable();
    this.subloct = ko.observable();
    this.appDate = ko.observable();
    this.tagg = ko.observable();
    this.recDate = ko.observable();
    this.results = ko.observable();
    this.minpack = ko.observable();
    this.maxpack = ko.observable();
    this.scheduler = ko.observable();
    this.dateinterview = ko.observable();
    this.conditions = ko.observable();
    this.respo = ko.observable();
    this.callerid = ko.observable();
    this.callernum = ko.observable();

    this.registerCompany = function () {
      alert("Hello");
    };
  }

  dispose() {
    // This runs when the component is torn down. Put here any logic necessary to clean up,
    // for example cancelling setTimeouts or disposing Knockout subscriptions/computeds.
  }
}

export default { viewModel: Addoffer, template: templateMarkup };
