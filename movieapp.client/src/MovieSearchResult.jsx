import React, { useState } from 'react';
import MovieDetails from './MovieDetails';
import { fetchMovie } from './utils/api';

const MovieSearchResult = ({ result }) => {
    const [isMovieSelected, setIsMovieSelected] = useState(false);
    const [movieDetails, setMovieDetails] = useState(null);

    const handleMovieSelect = async (imdbID) => {
        if (movieDetails === null) {
            setMovieDetails(await fetchMovie(imdbID));
        }
        setIsMovieSelected((prevState) => !prevState)
    };

    return (
        <div>
            <li key={result.imdbID} onClick={() => handleMovieSelect(result.imdbID)}>
                <div>
                    <h3>{result.Title} ( {result.Year} ) {isMovieSelected ? "Show less" : "Click to show more"}</h3>
                </div>
            </li>
            {isMovieSelected && (
                <MovieDetails movie={movieDetails} />
            )}
        </div>
    );
};

export default MovieSearchResult;
