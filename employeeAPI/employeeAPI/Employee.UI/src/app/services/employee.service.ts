import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import environment from 'src/enironments/environment.prod';
import { Employee } from '../models/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private url = "Employee"; 
  constructor(private http: HttpClient) { }

  public getemployee(): Observable<Employee[]> {
    
    return this.http.get<Employee[]>(`${environment.apiUrl}/${this.url}`);
  }

  
  public updateemployee(employee:Employee): Observable<Employee[]> {
    
    return this.http.put<Employee[]>(`${environment.apiUrl}/${this.url}`,employee);
  }

  public createemployee(employee:Employee): Observable<Employee[]> {
    
    return this.http.post<Employee[]>(`${environment.apiUrl}/${this.url}`,employee);
  }

  public deleteemployee(employee: Employee): Observable<Employee[]> {
    
    return this.http.delete<Employee[]>(`${environment.apiUrl}/${this.url}/${employee.id}`);
  }
}
