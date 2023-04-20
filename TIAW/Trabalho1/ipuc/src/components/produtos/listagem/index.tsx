import { Layout } from "components";
import Link from "next/link";

export const ListagemProdutos: React.FC = () => {
    return (

        <Layout titulo="Lista de Produtos Cadastrados">
            <Link href="/cadastros/produtos">
                <button className="button">Cadastrar</button>
            </Link>
        </Layout>
    )
}
