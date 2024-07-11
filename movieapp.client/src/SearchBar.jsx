import React from 'react';
import { fetchMovies } from './utils/api';
import { setSearchHistoryCookie } from './utils/cookieUtils';

const SearchBar = ({ searchQuery, setSearchQuery, setSearchHistory, setSearchResults }) => {
  const handleSearch = (event) => {
    event.preventDefault();
    if (searchQuery){
      searchMovies();
    }
  };

  const searchMovies = async () => {
    setSearchHistory((prevRecentSearches) => {
      const updatedSearchHistory = [searchQuery, ...prevRecentSearches.filter(q => q !== searchQuery)].slice(0, 5);
      setSearchHistoryCookie(updatedSearchHistory);
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
