import React, { useEffect } from 'react';
import { getSearchHistory } from './utils/cookieUtils';

const SearchHistory = ({ SearchHistory, setRecentSearches }) => {
    useEffect(() => {
        // Load recent searches from cookies
        const savedRecentSearches = getSearchHistory();
        if (savedRecentSearches) {
            setRecentSearches(JSON.parse(savedRecentSearches));
        }
    }, []);

    return (
        <>
            {SearchHistory.length > 0 && (
                <div className="recent-searches">
                    <h3>Recent Searches</h3>
                    <ul>
                        {SearchHistory.map((query, index) => (
                            <li key={index}>
                                {query}
                            </li>
                        ))}
                    </ul>
                </div>
            )}
        </>
    );
};

export default SearchHistory;
