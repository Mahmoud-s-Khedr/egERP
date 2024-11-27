import  { createContext, useContext, useState } from 'react';
import { ThemeProvider } from 'styled-components';
import PropTypes from 'prop-types';

// Define the themes for dark and light mode
const lightTheme = {
  background: '#FFFFFF', 
  componentBackground: '#e4e6e9', 
  text: '#000000',
  primary: '#007bff',
  secondary: '#59e264',
  border: '#ddd',
  borderRadius: '10px',
  link: '#007bff',
  accent: '#f0f0f0',
  fontSize: {
    small: '12px',
    medium: '16px',
    large: '18px',
    xlarge: '24px',
  },
};

const darkTheme = {
  background: '#1b1b1b', 
  componentBackground: '#3b3b3b', 
  borderRadius: '10px',
  text: '#FFFFFF',
  primary: '#007bff' ,
  secondary:'#5cd166' ,
  border: '#333',
  link: '#bb86fc',
  accent: '#333',
  fontSize: {
    small: '12px',
    medium: '16px',
    large: '18px',
    xlarge: '24px',
  },
};


// Create a context to toggle themes
const ThemeContext = createContext();

// Custom hook to use the theme context
export const useTheme = () => useContext(ThemeContext);

// ThemeProvider component to provide themes and toggle function
export const AppThemeProvider = ({ children }) => {
  const [isDarkMode, setIsDarkMode] = useState(false);

  const toggleTheme = () => {
    setIsDarkMode(!isDarkMode);
  };

  return (
    <ThemeContext.Provider value={{ toggleTheme, isDarkMode,theme: isDarkMode ? darkTheme : lightTheme }}>
      <ThemeProvider theme={isDarkMode ? darkTheme : lightTheme} isDarkMode={isDarkMode}>
        {children}
      </ThemeProvider>
    </ThemeContext.Provider>
  );
};

AppThemeProvider.propTypes = {
  children: PropTypes.node.isRequired,
};
