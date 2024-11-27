import React from 'react';
import { NavLink } from 'react-router-dom';
import styled from 'styled-components';

// Styled components for dropdown menu
const DropdownWrapper = styled.div`
  position: absolute;
  display: ${({ showDropdown }) => (showDropdown ? 'block' : 'none')};
  top:40px;
  right: 0;
  height: 120px;
  width:180px ;
`;

const DropdownContent = styled.ul`
  position: absolute;
  background-color: ${({ theme }) => theme.componentBackground};
  min-width: 160px;
  box-shadow: 0 8px 16px rgba(0, 0, 0, 0.2);
  border-radius: 5px;
  padding: 10px 0;
  z-index: 1000;
  list-style: none;

  li {
    padding: 10px 20px;
    color: ${({ theme }) => theme.text};
    cursor: pointer;
    transition: background 0.2s;
    display: flex;
    align-items: center;
    font: ${({ theme }) => theme.fontSize.large};
    &:hover {
      background-color: #8d8d8d;
    }
  }
`;
const StyledNavLink = styled(NavLink)`
  text-decoration: none;
  color: ${({ theme }) => theme.text};
  display: flex;
  width: 100%;
  
`;

const Icon = styled.div`
  font-size: 18px;
  width: 50%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
`;

const DropdownMenu = ({ options = [], onOptionSelect,showDropdown }) => {
  const handleOptionClick = (option) => {
    if (onOptionSelect) {
      onOptionSelect(option);
    }
  };

  return (
    <DropdownWrapper showDropdown={showDropdown}>
      <DropdownContent>
        {options.map((option, index) => (
          <li key={index} onClick={() => handleOptionClick(option)}>
            <StyledNavLink to={option.to}><Icon>{option.label} </Icon> {<Icon style={{fontSize:"20px"}}>{option.icon}</Icon>} </StyledNavLink>
          </li>
        ))}
      </DropdownContent>
    </DropdownWrapper>
  );
};

export default DropdownMenu;
