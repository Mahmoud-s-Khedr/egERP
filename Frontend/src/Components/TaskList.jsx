import styled from "styled-components"
import useTheme from "../Context/useTheme"
import TaskItem from "./TaskItem";
import { useRef } from "react";

const TaskListContainer = styled.div`
    display:flex;
    flex-direction: column;
    flex-wrap: wrap;
    width: calc(100%/3 - 24px);
    padding: 16px 24px;
    background-color: ${({theme}) => theme.ComponentBackground};
    color: ${({theme}) => theme.text};
    height: fit-content;
    border-radius: 8px;
    gap: 10px;
`

const ListHeader = styled.header`
    width: 100%;
    display: flex;
    justify-content: space-between;
    font-size: 32px;
    color: ${({theme}) => theme.darkgray};

`

function TaskList({selectedTask, setSelectedTask, color}) {
    const {theme} = useTheme();
    const listRef = useRef(null);

    function handleDragOver(e) {
        e.preventDefault();
        e.stopPropagation();
    };

    function handleDrop(e) {
        e.preventDefault();
        e.stopPropagation();
        
        if (!selectedTask || !listRef.current) return;

        // Find the closest task list container
        const dropTarget = e.target.closest('.task-list-container');
        
        if (dropTarget) {
            // Get the color of the list we're dropping into
            const targetListColor = dropTarget.getAttribute('data-list-color') || color;
            
            if (selectedTask.headerRef.current) {
                selectedTask.headerRef.current.style.color = targetListColor;
                selectedTask.element.setAttribute('data-list-color', targetListColor);
            }
            
            // Make sure we're not dropping on itself
            if (selectedTask.element.parentNode !== dropTarget) {
                dropTarget.appendChild(selectedTask.element);
            }
            
            setSelectedTask(null);
        }
    };

    return (
        <TaskListContainer 
            ref={listRef}
            className="task-list-container"
            theme={theme} 
            onDragOver={handleDragOver}
            onDrop={handleDrop}
            data-list-color={color}
        >
            <ListHeader theme={theme}>To Do</ListHeader>
            <TaskItem selectedTask={selectedTask} setSelectedTask={setSelectedTask} color={color}/>
            <TaskItem selectedTask={selectedTask} setSelectedTask={setSelectedTask} color={color}/>
            <TaskItem selectedTask={selectedTask} setSelectedTask={setSelectedTask} color={color}/>
        </TaskListContainer>
    )
}

export default TaskList