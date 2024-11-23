import Dropdown from 'react-bootstrap/Dropdown';
import DropdownButton from 'react-bootstrap/DropdownButton';

function BasicButtonExample() {
  return (
    <DropdownButton className='p-0' id="dropdown-basic-button"  title="Sort by">
      <Dropdown.Item href="#/action-1">Orders</Dropdown.Item>
      <Dropdown.Item href="#/action-2">Sales</Dropdown.Item>
      <Dropdown.Item href="#/action-3">Older</Dropdown.Item>
      <Dropdown.Item href="#/action-3">Newer</Dropdown.Item>
    </DropdownButton>
  );
}

export default BasicButtonExample;