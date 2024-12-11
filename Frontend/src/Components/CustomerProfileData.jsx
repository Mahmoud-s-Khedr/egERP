import styled from "styled-components"
import useTheme from "../Context/useTheme"
import { IoAdd } from "react-icons/io5"

const Conatianer = styled.div`
    display: flex;
    margin: 24px 0px;
    gap: 24px;
    background-color: ${({theme}) => theme.ComponentBackground};
    border-radius: 8px;
    padding: 24px;
`

const Column = styled.div`
    display: flex;
    flex-direction: column;
    width: calc(100%/3);
    gap: 12px;
`

const ColumnHeader = styled.div`
    font-size: 24px;
    color: ${({theme}) => theme.lightgraynav};
`

const ColumnBody = styled.div`
    font-size: 24px;
    color: ${({theme}) => theme.text};
`
const AddButton = styled.button`
    border: dashed 2px ${({theme}) => theme.lightgray};
    border-radius: 8px;
    margin-top: 24px;
    font-size: 24px;
    display: flex;
    justify-content: center;
    align-items: center;
    width:50%;
    background-color: transparent;
    cursor: pointer;
    &:hover{
        background-color: ${({theme}) => theme.primary}20;
        color: ${({theme}) => theme.primary};
    }

`

function CustomerProfileData() {
    const {theme} = useTheme()
    return (
        <Conatianer theme={theme}>
            <Column>
                <ColumnHeader theme={theme}>Addresses</ColumnHeader>
                <ColumnBody theme={theme}>Egypt / Cairo / downtwon / street3</ColumnBody>
                <ColumnBody theme={theme}>Egypt / Cairo / downtwon / street3</ColumnBody>
                <AddButton theme={theme}><IoAdd/></AddButton>
            </Column>
            <Column>
                <ColumnHeader theme={theme}>Emails</ColumnHeader>
                <ColumnBody theme={theme}>mohsen@gmail.com</ColumnBody>
                <AddButton theme={theme}><IoAdd/></AddButton>
            </Column>
            <Column>
                <ColumnHeader theme={theme}>Contacts</ColumnHeader>
                <ColumnBody theme={theme}>+20123456789</ColumnBody>
                <AddButton theme={theme}><IoAdd/></AddButton>
            </Column>

        </Conatianer>
    )
}   
export default CustomerProfileData