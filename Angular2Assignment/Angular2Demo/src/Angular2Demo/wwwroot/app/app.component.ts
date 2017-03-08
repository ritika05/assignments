import { Component } from '@angular/core';
import { Http } from "@angular/http";

@Component({
    selector: 'my-app',
    templateUrl: 'app/app.html',
})
export class AppComponent {
    name = 'Angular';
    employees: Employee[] = new Array<Employee>();
    employee: Employee = new Employee;
    emp: Employee = new Employee;
    Edit: boolean = false
    Update: boolean[] = new Array<boolean>();
    constructor(public http: Http) {
        this.http.get("http://localhost:5000/api/Employees", this.employees).subscribe((response) => {
            this.employees = response.json();
        });
        
    }
    UpdateArray() {
        for (var i = 0; i < this.employees.length; i++) {
            this.Update.push(false);
        }
    }
    AddEmployee() {
        this.http.post("http://localhost:5000/api/Employees", this.employee).subscribe((response) => {
            this.employees.push(response.json());
            this.employee = new Employee();
        })
    }
    EditEmployee(employeeEdit: Employee) {
        this.Edit = true;
        this.emp = employeeEdit;
        //var IdVariable = this.emp.Id;

        this.Update[this.employees.indexOf(employeeEdit)] = true;
        for (var i = 0; i < this.employees.length; i++) {
            this.Update[i] = false;
            //if (IdVariable == this.employees[i].Id) {
            //    this.Update[i] = true;
            //}
        }
    }
    UpdateEmployee() {
        this.http.put("http://localhost:5000/api/Employees/"+this.emp.Id, this.emp).subscribe((response) => {
            response.json();
            for (var i = 0; i < this.employees.length; i++) 
                this.Update[i] = false;
        })
    }
    DeleteEmployee(employeeDelete: Employee) {
        this.http.delete("http://localhost:5000/api/Employees/" + employeeDelete.Id).subscribe((response) => {
            this.employees.splice(this.employees.findIndex(x => x.Id == employeeDelete.Id), 1);
        })
    }

    
}
class Employee {
    Id: number;
    Name: string;
    Address: string;
}