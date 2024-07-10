// src/utils/api.js
export const fetchMovies = async (searchQuery) => {
    const response = await fetch(`/Omdb/GetMovies/${encodeURIComponent(searchQuery)}`);
    const data = await response.json();
    return data.Search || [];
};

export const fetchMovie = async (imdbID) => {
    const response = await fetch(`/Omdb/Movie/${encodeURIComponent(imdbID)}`);
    return await response.json();
};