import React, { useState } from 'react';
import MovieSearchResults from './MovieSearchResults';
import SearchHistory from './SearchHistory';
import SearchBar from './SearchBar';

const MovieApp = () => {
  const [searchQuery, setSearchQuery] = useState('');
  const [searchResults, setSearchResults] = useState([]);
  const [searchHistory, setSearchHistory] = useState([]);

  return (
    <div>
      <h1>Movie Search App</h1>
      <SearchBar
        searchQuery={searchQuery}
        setSearchQuery={setSearchQuery}
        setRecentSearches={setSearchHistory}
        setSearchResults={setSearchResults}
      />
      <SearchHistory 
        SearchHistory={searchHistory}
        setRecentSearches={setSearchHistory} />
      <MovieSearchResults searchResults={searchResults} />
    </div>
  );
};

export default MovieApp;
