import { useContext } from "react";
import ThemeContext from "./ThemeContext";

export default function useTheme() {
    const context = useContext(ThemeContext);
    if (!context) {
        throw new Error('useTheme must be used within a ThemeProvider');
    }
    return {
        theme: context.theme,
        isDarkMode: context.isDarkMode,
        toggleTheme: context.toggleTheme
    };
}