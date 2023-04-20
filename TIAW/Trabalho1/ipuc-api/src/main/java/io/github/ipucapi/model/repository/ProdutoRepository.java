package io.github.ipucapi.model.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import io.github.ipucapi.model.Produto;

public interface ProdutoRepository extends JpaRepository<Produto, Long> {

}
