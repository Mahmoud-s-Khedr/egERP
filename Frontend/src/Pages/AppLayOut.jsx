
import { Outlet } from 'react-router-dom'

export default function AppLayOut() {
    return (
        <div className="App">
            <div className="App-header">
                <Outlet/>
            </div>
        </div>
    )
}