import ThemeContext from "./ThemeContext";
import { useState } from "react";

const lightTheme = {
    primary: "#3783B5",
    secondary: "#15CB3D",
    background: "#D9D9D9",
    ComponentBackground: "#FFFFFF",
    text: "#000000",
    lightgraynav:"#CCCCCC",
    lightgray:"#cccccc",
    darkgray:"#545657",
    white:"#FFFFFF",
    yellow:"#D6C01C",
    red:"#DD4465",
};

const darkTheme = {
    primary: "#3783B5",
    secondary: "#15CB3D",
    background: "#161616",
    ComponentBackground: "#353535",
    darkgray:"#777a7c",
    text: "#FFFFFF",
    lightgray:"#6b6b6b",
    lightgraynav:"#CCCCCC",
    white:"#FFFFFF",
    yellow:"#D6C01C",
    red:"#DD4465",
};

function Theme({children}) {
    const [isDarkMode, setIsDarkMode] = useState(false);

    const toggleTheme = () => {
        setIsDarkMode(prev => !prev);
    };

    const value = {
        theme: isDarkMode ? darkTheme : lightTheme,
        isDarkMode,
        toggleTheme
    };

    return (
        <ThemeContext.Provider value={value}>
            {children}
        </ThemeContext.Provider>
    )
}

export default Theme;