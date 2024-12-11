import styled from "styled-components"
import useTheme from "../Context/useTheme"
import { IoCartOutline } from "react-icons/io5"

const Container = styled.div`
    display:flex;
    flex-direction: column;
    flex-wrap: wrap;
    width: calc(100%/2 - 24px);
    justify-content: space-evenly;
    padding: 16px 24px;
    background-color: ${({theme}) => theme.ComponentBackground};
    color: ${({theme}) => theme.text};
    border-radius: 8px;
    gap: 24px;
`

const NameContainer = styled.div`
    font-size: 28px;
    color: ${({theme}) => theme.text};
    gap: 12px;
`

const PriceContainer = styled.div`
    font-size: 28px;
    color: ${({theme}) => theme.lightgraynav};
    gap: 12px;
`
const DescriptionHeader = styled.div`
    font-size: 28px;
    color: ${({theme}) => theme.lightgraynav};
    gap: 12px;
    margin-bottom: 12px;
`

const DescriptionContainer = styled.div`
    font-size: 24px;
    color: ${({theme}) => theme.text};
    line-height: 36px;
    gap: 12px;
`

const AddButton = styled.button`
    background-color: ${({theme}) => theme.secondary};
    color: white;
    border: none;
    font-size: 28px;
    padding: 8px 16px;
    border-radius:8px;
    cursor: pointer;
`

const Row = styled.div`
    display:flex;
    gap: 12px;
    justify-content: space-evenly;
`

function ProductData() {
    const {theme} = useTheme()
    return (
        <>
            <Container theme={theme}>
                <NameContainer theme={theme}>Product Name model 23324</NameContainer>
                <Row>
                <PriceContainer theme={theme}>Price : <span style={{color:theme.yellow}}>1000$</span></PriceContainer>
                 
                <PriceContainer theme={theme}>stock : <span style={{color:theme.secondary}}>200</span></PriceContainer>
                </Row>
                <DescriptionContainer theme={theme}>
                    <DescriptionHeader theme={theme}>Description</DescriptionHeader>
                 Lorem ipsum dolor sit, amet consectetur
                     adipisicing elit. Assumenda officiis veniam nostrum? Voluptates neque
                      debitis numquam nostru
                      mLorem ipsum dolor sit amet consectetur adipisicing elit
                      . Quisquam, quae
                .</DescriptionContainer>
                <AddButton theme={theme}><IoCartOutline/> Add Order </AddButton>
            </Container>
        </>
    )
}

export default ProductData