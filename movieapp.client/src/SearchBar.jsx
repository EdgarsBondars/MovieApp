import React from 'react';
import { fetchMovies } from './utils/api';
import { setSearchHistory } from './utils/cookieUtils';

const SearchBar = ({ searchQuery, setSearchQuery, setRecentSearches, setSearchResults }) => {
  const handleSearch = (event) => {
    event.preventDefault();
    searchMovies();
  };

  const searchMovies = async () => {
    setRecentSearches((prevRecentSearches) => {
      const updatedSearchHistory = [searchQuery, ...prevRecentSearches.filter(q => q !== searchQuery)].slice(0, 5);
      setSearchHistory(updatedSearchHistory);
      return updatedSearchHistory;
    });
    
      setSearchResults(await fetchMovies(searchQuery) || []);
  };

  return (
    <>
      <form className="search-bar" onSubmit={handleSearch}>
        <input
          type="text"
          value={searchQuery}
          onChange={(e) => setSearchQuery(e.target.value)}
          placeholder="Search for a movie..."
        />
        <button type="submit">
          Search
        </button>
      </form>
    </>
  );
};

export default SearchBar;
