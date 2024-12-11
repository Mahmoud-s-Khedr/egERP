import styled from "styled-components"
import useTheme from "../Context/useTheme"
import { CiEdit} from "react-icons/ci"
import { BiPhoneOutgoing } from "react-icons/bi"
import { MdOutlineEmail } from "react-icons/md"

const ProfileHeaderContainer = styled.div`
    display:flex;
    flex-wrap: wrap;
    gap: 24px;

    justify-content: space-between;
    align-items: center;
    background-color: ${({theme}) => theme.ComponentBackground};
    border-radius: 8px; 
    padding: 24px;
`
const ProfileImage = styled.img`
    width: 80px;
    height: 80px;
    border-radius: 50%;
    margin-right: 10px;
`
const ProfileConatiner = styled.div`
    display:flex;
    gap: 24px;
`
const NameContainer = styled.div`
    display:flex;
    flex-direction: column;
    justify-content: center;
    gap: 5px;
`
const ProfileName = styled.div`
    font-size: 32px;
    color: ${({theme}) => theme.text};

`
const Title = styled.div`
    font-size: 16px;
    color: ${({theme}) => theme.lightgraynav};
`
const ButtonContainer = styled.div`
    display:flex;
    justify-self: flex-end;
    gap: 24px;
`
const Button= styled.button`
    background-color: ${({color}) => color};
    color: white;
    border: none;
    font-size: 24px;
    padding: 8px 16px;
    border-radius: 4px;
    display:flex;
    gap: 10px;
    align-items: center;
    justify-content: center;
    cursor: pointer;
`
function ProfileHeader() {
    const {theme} = useTheme()
    return (
        <ProfileHeaderContainer theme={theme}>
            <ProfileConatiner>
              <ProfileImage 
            src="https://images.unsplash.com/photo-1535713875002-d1d0cf377fde?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=870&q=80"/>
            
           <NameContainer>
                <ProfileName theme={theme}>John Doe mohsen ibrahim</ProfileName>   
                <Title theme={theme}>software developer</Title>   
            </NameContainer>
            </ProfileConatiner>
            <ButtonContainer>
                <Button color={theme.secondary}><CiEdit/>Edit Profile</Button>
                <Button color={theme.primary}><MdOutlineEmail/>Email</Button>
                <Button color={theme.red}><BiPhoneOutgoing/>Call</Button>
            </ButtonContainer>
        </ProfileHeaderContainer>
    )
}


export default ProfileHeader