import SideBar from "../Components/SideBar/SideBar";
import { useState } from "react";
import { Outlet } from "react-router-dom";
import TopNav from "../Components/NavBar/TopNav";
import { useTheme } from "../Context/ThemeContext";
import { useRef } from "react";
function AppLayOut() {
  const [sidebarVisible, setSidebarVisible] = useState(false);
  const {theme, toggleTheme} = useTheme();
    const toggleSidebar = () => {
      setSidebarVisible(!sidebarVisible);
    };
  
    
    return (
      <div  className={`app container-fluid p-0 ${ theme? 'dark-mode' : ''}`}>
              <TopNav 
                toggleSidebar={toggleSidebar}
                toggleTheme={toggleTheme}
              />
              <div className="d-flex">
              <SideBar visible={sidebarVisible} theme={theme} />
                <div 
                  className={`content-wrapper page-content  p-4 ${!sidebarVisible ? 'expanded' : ' margin-page'} 
                    ${theme ? 'dark-mode' : ''}`}

                  style={{ 
                    marginTop: '60px',
                    transition: 'margin-left 0.3s ease-in-out'
                  }}
                >
                <Outlet />
                </div>
              </div>
            </div>
    );
};

export default AppLayOut;