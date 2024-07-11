import React, { useEffect } from 'react';
import { getSearchHistoryCookie } from './utils/cookieUtils';

const SearchHistory = ({ searchHistory, setSearchHistory }) => {
    useEffect(() => {
        // Load recent searches from cookies
        const cookieSearchHistory = getSearchHistoryCookie();
        if (cookieSearchHistory) {
            setSearchHistory(JSON.parse(cookieSearchHistory));
        }
    }, []);

    return (
        <>
            {searchHistory.length > 0 && (
                <div className="recent-searches">
                    <h3>Recent Searches</h3>
                    <ul>
                        {searchHistory.map((query, index) => (
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
