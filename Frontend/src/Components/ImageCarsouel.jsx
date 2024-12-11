import { MdArrowBack, MdArrowBackIos, MdArrowForward, MdArrowForwardIos } from "react-icons/md"
import styled from "styled-components"
const Container = styled.div`
    width: ${({width}) => width};
    height: 100%;
    border-radius: 8px;
    position: relative;
`
const Image= styled.img`
    width: ${({width}) => width};
    height: 100%;
    object-fit: cover;
    border-radius: 8px;

`

const Button = styled.button`
    background-color: transparent;
    color: #ffffff8b;
    border: none;
    padding: 8px 16px;
    border-radius: 4px;
    cursor: pointer;
    position: absolute;
    right: ${({right}) => right};
    left: ${({left}) => left};
    font-size: 60px;
    top: 50%;
    margin-right: 8px;
    &:hover{
        color: #ffffff;
    }
`

function ImageCarsouel({width}) {
    return (
        <Container width={width}>
        <Image src="https://images.unsplash.com/photo-1504674900247-0877df9cc836?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1470&q=80" width="100%" height="100%" />
        <Button color="blue" right="0"><MdArrowForwardIos/></Button>
        <Button color="green" left="0"><MdArrowBackIos/></Button>
        </Container>
    )
}  

export default ImageCarsouel;