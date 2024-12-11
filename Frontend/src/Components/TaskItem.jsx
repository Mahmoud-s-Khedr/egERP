import styled from "styled-components"
import useTheme from "../Context/useTheme"
import { useRef } from "react"

const TaskItemContainer = styled.div`
    display:flex;
    flex-direction: column;
    flex-wrap: wrap;
    padding: 16px 24px;
    background-color: ${({theme}) => theme.lightgray};
    color: ${({theme}) => theme.text};
    border-radius: 8px;
    gap: 10px;
`
const TaskItemHeader = styled.header`
    width: 100%;
    display: flex;
    justify-content: space-between;
    font-size: 32px;
    color:${({color})=>color};
`

const TaskItemBody = styled.div`
    width: 100%;
    display: flex;
    justify-content: center;
    font-size: 16px;
`
function TaskItem({selectedTask, color, setSelectedTask}) {
    const {theme} = useTheme();
    const headerRef = useRef(null);
    const containerRef = useRef(null);
    
    const handleDragStart = (e) => {
        e.stopPropagation();
        setSelectedTask({
            element: containerRef.current,
            headerRef: headerRef,
            originalColor: color,
            listColor: color
        });
        e.dataTransfer.setData('text/plain', ''); 
    };

    return (
        <TaskItemContainer 
            ref={containerRef}
            theme={theme} 
            draggable={true} 
            onDragStart={handleDragStart}
            onDragEnd={() => setSelectedTask(null)}
            data-list-color={color}
        >
            <TaskItemHeader ref={headerRef} color={color}>Task Header</TaskItemHeader>
            <TaskItemBody theme={theme}>Lorem ipsum dolor sit amet 
                consectetur adipisicing elit. Hic corporis iste totam. Adipisci 
                sit libero amet praesentium </TaskItemBody>
        </TaskItemContainer>
    )
}

export default TaskItem