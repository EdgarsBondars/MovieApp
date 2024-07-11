// src/utils/cookieUtils.js
import Cookies from 'js-cookie';

const searchHistoryCookie = 'searchHistory';

export const getSearchHistoryCookie = () => {
  return Cookies.get(searchHistoryCookie);
};

export const setSearchHistoryCookie = (searches) => {
  Cookies.set(searchHistoryCookie, JSON.stringify(searches), { expires: 7 });
};
