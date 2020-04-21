import React, { Component } from 'react';

import './app.scss'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <div className='homepage'>
        <header>
          This is the header
        </header>
        <section className='social'>
          Sign in to see what your friends are watching.
        </section>
        <section className='browse'>
          Browse by category and refine your search.
        </section>
        <section className='recommended'>
          Tell us a movie you like and we'll find similar movies.
        </section>
        <section className='trending'>
          Discover top movies people are talking about.
        </section>
        <footer>
          Privacy | Developers
        </footer>
      </div>
    );
  }
}
