import React from 'react';

const MovieDetails = ({ movie }) => {
    return (
        <div className="movie-details">
            <h2>{movie.Title}</h2>
            <div>
                <img src={movie.Poster} alt={movie.Title} />
                <p>{movie.Plot}</p>
                <p>IMDb Rating: {movie.imdbRating}</p>
                <p>Released: {movie.Released}</p>
                <p>Director: {movie.Director}</p>
            </div>
        </div>
    );
};

export default MovieDetails;
