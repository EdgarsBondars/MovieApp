import React from 'react';
import MovieSearchResult from './MovieSearchResult';

const MovieSearchResults = ({ searchResults }) => {
    if (!searchResults || searchResults.length === 0) {
        return (
            <div className="search-results">
                <h2>Search Results</h2>
                <p>No search results found.</p>
            </div>
        );
    }

    return (
        <div className="search-results">
            <h2>Search Results</h2>
            <ul>
                {searchResults.map((result) => (
                    <MovieSearchResult key={result.imdbID} result={result} />
                ))}
            </ul>
        </div>
    );
};

export default MovieSearchResults;