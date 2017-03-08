"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var http_1 = require("@angular/http");
var AppComponent = (function () {
    function AppComponent(http) {
        var _this = this;
        this.http = http;
        this.name = 'Angular';
        this.employees = new Array();
        this.employee = new Employee;
        this.emp = new Employee;
        this.Edit = false;
        this.Update = new Array();
        this.http.get("http://localhost:5000/api/Employees", this.employees).subscribe(function (response) {
            _this.employees = response.json();
        });
    }
    AppComponent.prototype.UpdateArray = function () {
        for (var i = 0; i < this.employees.length; i++) {
            this.Update.push(false);
        }
    };
    AppComponent.prototype.AddEmployee = function () {
        var _this = this;
        this.http.post("http://localhost:5000/api/Employees", this.employee).subscribe(function (response) {
            _this.employees.push(response.json());
            _this.employee = new Employee();
        });
    };
    AppComponent.prototype.EditEmployee = function (employeeEdit) {
        this.Edit = true;
        this.emp = employeeEdit;
        //var IdVariable = this.emp.Id;
        this.Update[this.employees.indexOf(employeeEdit)] = true;
        for (var i = 0; i < this.employees.length; i++) {
            this.Update[i] = false;
        }
    };
    AppComponent.prototype.UpdateEmployee = function () {
        var _this = this;
        this.http.put("http://localhost:5000/api/Employees/" + this.emp.Id, this.emp).subscribe(function (response) {
            response.json();
            for (var i = 0; i < _this.employees.length; i++)
                _this.Update[i] = false;
        });
    };
    AppComponent.prototype.DeleteEmployee = function (employeeDelete) {
        var _this = this;
        this.http.delete("http://localhost:5000/api/Employees/" + employeeDelete.Id).subscribe(function (response) {
            _this.employees.splice(_this.employees.findIndex(function (x) { return x.Id == employeeDelete.Id; }), 1);
        });
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'my-app',
            templateUrl: 'app/app.html',
        }), 
        __metadata('design:paramtypes', [http_1.Http])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
var Employee = (function () {
    function Employee() {
    }
    return Employee;
}());
//# sourceMappingURL=app.component.js.map