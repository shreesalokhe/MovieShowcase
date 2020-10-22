import { Component, OnInit } from '@angular/core';
import { ContactService } from 'src/app/services/contact.service';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
  styleUrls: ['./contact-list.component.css']
})
export class ContactListComponent implements OnInit {
  movies: any;
  currentMovie = null;
  currentIndex = -1;
  title = '';
  constructor(private _contactService: ContactService) { }

  ngOnInit(): void {
    this.retrieveContacts();
  }
  retrieveContacts(): void {
    this._contactService.getAll()
      .subscribe(
        data => {
           this.movies = data;
           this.currentMovie = data[0];
           this.currentIndex=0;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  refreshList(): void {
    this.retrieveContacts();
    this.currentMovie = null;
    this.currentIndex = -1;
  }

  setActiveContact(mv, index): void {
    debugger;
    this.currentMovie = mv;
    this.currentIndex = index;
  }


  searchMovie(): void { 
    
    this._contactService.findMoviesByYear(this.title)
      .subscribe(
        data => {
          this.movies = data;
          this.setActiveContact(data[0],0);
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }
}
