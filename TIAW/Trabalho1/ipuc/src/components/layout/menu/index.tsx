import { Url } from "next/dist/shared/lib/router/router"
import Link from "next/link"

export const Menu: React.FC = () => {
    return(
        <aside className="column is-2 is-narrow-mobile is-fullheight section is-hidden-mobile">
            <p className="menu-label is-hidden-touch">
                Minhas Vendas
            </p>
            <ul className="menu-list">
                <li>
                    <MenuItem href="/" label="Home" />
                    <MenuItem href="/consultas/produtos" label="Produtos" />
                    <MenuItem href="/" label="Config" />                    
                </li>
            </ul>
        </aside>
    )
}

interface MenuItemProps {
    href: Url,
    label: String
}

export const MenuItem: React.FC<MenuItemProps> = (props: MenuItemProps) => {
    return (
        <Link href={props.href}>
                <span className="icon"></span> {props.label}
        </Link>

    )
}