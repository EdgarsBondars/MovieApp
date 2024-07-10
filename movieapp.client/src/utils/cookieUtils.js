// src/utils/cookieUtils.js
import Cookies from 'js-cookie';

const searchHistoryCookie = 'searchHistory';

export const getSearchHistory = () => {
  return Cookies.get(searchHistoryCookie);
};

export const setSearchHistory = (searches) => {
  Cookies.set(searchHistoryCookie, JSON.stringify(searches), { expires: 7 });
};
