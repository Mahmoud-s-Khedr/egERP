import { Navbar, Container, Button, Image, NavDropdown } from 'react-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { useState } from 'react';
import { 
  faBars, 
  faSun, 
  faMoon,
  faUser,
  faCog,
  faSignOutAlt
} from '@fortawesome/free-solid-svg-icons';
import { useTheme } from "../../Context/ThemeContext";

const TopNav = ({ toggleSidebar }) => {
  const [showProfileDropdown, setShowProfileDropdown] = useState(false);
  const {theme, toggleTheme} = useTheme();

  const handleLogout = () => {
    // Add your logout logic here
    console.log('Logging out...');
  };

  return (
    <Navbar 
      className={`top-nav `}
      expand="lg"
    >
      <Container fluid>
        <button
          className="sidebar-toggle bg-transparent border-0 fs-2"
          onClick={toggleSidebar}
        >
          <FontAwesomeIcon icon={faBars} />
        </button>

        <div className="ms-auto d-flex align-items-center">
          {/* Theme Toggle Button */}
          <button
            className="theme-toggle me-3 bg-transparent border-0 fs-2"
            onClick={toggleTheme}
          >
            <FontAwesomeIcon icon={theme ? faMoon : faSun} />
          </button>

          {/* Profile Picture and Dropdown */}
          <div className="profile-section">
            <Image
              src="https://via.placeholder.com/40"
              roundedCircle
              className="profile-pic"
              onClick={() => setShowProfileDropdown(!showProfileDropdown)}
            />
            <NavDropdown
              title=""
              id="basic-nav-dropdown"
              show={showProfileDropdown}
              onToggle={setShowProfileDropdown}
              align="end"
            >
              <div className="dropdown-header">
                <Image
                  src="https://via.placeholder.com/60"
                  roundedCircle
                  className="dropdown-profile-pic"
                />
                <div className="user-info">
                  <p className="user-name">John Doe</p>
                  <p className="user-email">john.doe@example.com</p>
                </div>
              </div>
              <NavDropdown.Divider />
              <NavDropdown.Item href="/profile">
                <FontAwesomeIcon icon={faUser} className="me-2" />
                Profile
              </NavDropdown.Item>
              <NavDropdown.Item href="/settings">
                <FontAwesomeIcon icon={faCog} className="me-2" />
                Settings
              </NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item onClick={handleLogout}>
                <FontAwesomeIcon icon={faSignOutAlt} className="me-2" />
                Logout
              </NavDropdown.Item>
            </NavDropdown>
          </div>
        </div>
      </Container>
    </Navbar>
  );
};

export default TopNav;