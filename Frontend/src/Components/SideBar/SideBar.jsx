import { Nav } from 'react-bootstrap';
import { NavLink, useLocation } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import {
  faHome,
  faUsers,
  faCog,
  faEnvelope,
  faChartBar
} from '@fortawesome/free-solid-svg-icons';

const menuItems = [
  { path: '/dashboard', name: 'Dashboard', icon: faHome },
  { path: '/customers', name: 'Customers', icon: faUsers },
  { path: '/settings', name: 'Settings', icon: faCog },
  { path: '/messages', name: 'Messages', icon: faEnvelope },
  { path: '/reports', name: 'Reports', icon: faChartBar },
];

// Add theme prop to receive the current theme
const Sidebar = ({ visible, theme }) => {
  const location = useLocation();

  return (
    <div className={`sidebar ${visible ? 'visible' : 'd-none w-0'} `}>
      <Nav className="flex-column">
        {menuItems.map((item, index) => (
          <Nav.Item key={index}>
            <NavLink 
              to={item.path}
              className={({ isActive }) => {
                const currentPath = location.pathname;
                const isMenuActive = currentPath.startsWith(item.path);
                return `nav-link  ${isMenuActive ? 'active' : ''} `;
              }}
            >
              <div className='w-100 w-md-auto d-flex justify-content-center my-2'>
              <FontAwesomeIcon icon={item.icon} className="mx-4 " />
              </div>
              <div className='w-100 w-md-auto d-flex justify-content-center'>
              {item.name}</div>
            </NavLink>
          </Nav.Item>
        ))}
      </Nav>
    </div>
  );
};

export default Sidebar;