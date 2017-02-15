<?xml version="1.0"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:param name="startDate" />
  <xsl:param name="endDate" />
  <xsl:param name="hospital" />
  <xsl:param name="departmentCollection" />
  <xsl:template match="/">
    <?mso-application progid="Excel.Sheet"?>

    <Workbook xmlns="urn:schemas-microsoft-com:office:spreadsheet"
              xmlns:o="urn:schemas-microsoft-com:office:office"
              xmlns:x="urn:schemas-microsoft-com:office:excel"
              xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet"
              xmlns:html="http://www.w3.org/TR/REC-html40">
      <DocumentProperties xmlns="urn:schemas-microsoft-com:office:office">
        <Author>georg</Author>
        <LastAuthor>Anastasia M</LastAuthor>
        <LastPrinted>2006-03-16T05:38:55Z</LastPrinted>
        <Created>2006-03-01T07:56:02Z</Created>
        <LastSaved>2007-11-01T07:01:31Z</LastSaved>
        <Company>rff</Company>
        <Version>15.00</Version>
      </DocumentProperties>
      <OfficeDocumentSettings xmlns="urn:schemas-microsoft-com:office:office">
        <AllowPNG />
      </OfficeDocumentSettings>
      <ExcelWorkbook xmlns="urn:schemas-microsoft-com:office:excel">
        <WindowHeight>8835</WindowHeight>
        <WindowWidth>15180</WindowWidth>
        <WindowTopX>120</WindowTopX>
        <WindowTopY>105</WindowTopY>
        <ProtectStructure>False</ProtectStructure>
        <ProtectWindows>False</ProtectWindows>
      </ExcelWorkbook>
      <Styles>
        <Style ss:ID="Default" ss:Name="Normal">
          <Alignment ss:Vertical="Bottom" />
          <Borders />
          <Font ss:FontName="Arial Cyr" x:CharSet="204" />
          <Interior />
          <NumberFormat />
          <Protection />
        </Style>
        <Style ss:ID="m63075042880">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075040800">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="12"
                ss:Bold="1" />
        </Style>
        <Style ss:ID="m63075040820">
          <Alignment ss:Horizontal="Left" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="m63075040840">
          <Alignment ss:Horizontal="Left" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="m63075040860">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075040880">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075040900">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075040920">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075040940">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075040960">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075040980">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075037472">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075037492">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075037552">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Bold="1" />
        </Style>
        <Style ss:ID="m63075037572">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Bold="1" />
        </Style>
        <Style ss:ID="m63075037592">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="8" />
        </Style>
        <Style ss:ID="m63075037612">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Bold="1" />
        </Style>
        <Style ss:ID="m63075038512">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075038572">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075038592">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075042672">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial Cyr" x:CharSet="204" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075042692">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial Cyr" x:CharSet="204" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075042712">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m63075042772">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s21">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s22">
          <Borders />
        </Style>
        <Style ss:ID="s23">
          <Alignment ss:Vertical="Bottom" />
          <Borders />
        </Style>
        <Style ss:ID="s24">
          <Alignment ss:Vertical="Center" ss:WrapText="1" />
          <Borders />
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="12"
                ss:Bold="1" />
        </Style>
        <Style ss:ID="s25">
          <Alignment ss:Vertical="Center" ss:WrapText="1" />
          <Borders />
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Bold="1" />
        </Style>
        <Style ss:ID="s26">
          <Borders />
          <Interior />
        </Style>
        <Style ss:ID="s27">
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="s28">
          <Alignment ss:Horizontal="Justify" ss:Vertical="Top" ss:WrapText="1" />
          <Borders />
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="12"
                ss:Bold="1" />
          <Interior />
        </Style>
        <Style ss:ID="s29">
          <Alignment ss:Horizontal="Justify" ss:Vertical="Top" ss:WrapText="1" />
          <Borders />
          <Font ss:FontName="Times New Roman" x:CharSet="204" x:Family="Roman"
                ss:Size="16" />
          <Interior />
        </Style>
        <Style ss:ID="s66">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior />
        </Style>
        <Style ss:ID="s67">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior />
        </Style>
        <Style ss:ID="s68">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior />
        </Style>
        <Style ss:ID="s72">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s73">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
          <Interior />
        </Style>
        <Style ss:ID="s75">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
          <Interior />
        </Style>
        <Style ss:ID="s77">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s78">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
          <Interior />
        </Style>
        <Style ss:ID="s79">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s83">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders />
          <Font ss:FontName="Arial" ss:Size="8" />
        </Style>
        <Style ss:ID="s84">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders />
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Bold="1" />
        </Style>
        <Style ss:ID="s91">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>

        <Style ss:ID="s105">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior />
        </Style>

        <Style ss:ID="s176">
          <Alignment ss:Horizontal="Left" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior />
        </Style>

      </Styles>
      <Worksheet ss:Name="Лист1">
        <Table ss:ExpandedColumnCount="30" x:FullColumns="1"
               x:FullRows="1">
          <Column ss:AutoFitWidth="0" ss:Width="182.25" />
          <Column ss:Index="19" ss:AutoFitWidth="0" ss:Width="37.5" />
          <Row>
            <Cell ss:Index="10" ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:Index="20" ss:MergeAcross="3" ss:StyleID="m63075040820">
              <Data
                ss:Type="String">
                Код форми за ЗКУД
              </Data>
            </Cell>
          </Row>
          <Row>
            <Cell ss:Index="10" ss:StyleID="s27" />
            <Cell ss:StyleID="s27" />
            <Cell ss:StyleID="s27" />
            <Cell ss:StyleID="s27" />
            <Cell ss:StyleID="s27" />
            <Cell ss:StyleID="s27" />
            <Cell ss:Index="20" ss:MergeAcross="3" ss:StyleID="m63075040840">
              <Data
                ss:Type="String">
                Код закладу за ЗКПО
              </Data>
            </Cell>
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
          </Row>
          <Row>
            <Cell ss:Index="20" ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
          </Row>
          <Row>
            <Cell ss:MergeAcross="2" ss:StyleID="m63075037592">
              <Data ss:Type="String">Міністерство охорони здоров'я України</Data>
            </Cell>
            <Cell ss:MergeAcross="15" ss:MergeDown="1" ss:StyleID="m63075040800">
              <Data
                ss:Type="String">
                Дані з обліку руху хворих і ліжкового фонду стаціонару, відділеню або профілю ліжок
              </Data>
            </Cell>
            <Cell ss:MergeAcross="3" ss:StyleID="s91">
              <Data ss:Type="String">МЕДИЧНА ДОКУМЕНТАЦІЯ</Data>
            </Cell>
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:MergeAcross="4" ss:StyleID="s83" />
          </Row>
          <Row>
            <Cell ss:MergeAcross="2" ss:StyleID="m63075037612">
              <Data ss:Type="String">
                <xsl:value-of select="$hospital" />
              </Data>
            </Cell>
            <Cell ss:Index="20" ss:MergeAcross="3" ss:StyleID="s91">
              <Data ss:Type="String">ФОРМА № 016/У</Data>
            </Cell>
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:MergeAcross="4" ss:StyleID="s84" />
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="15.75">
            <Cell ss:MergeAcross="22" ss:StyleID="m63075037552">
              <Data ss:Type="String">
                за период с <xsl:value-of select="$startDate" /> по <xsl:value-of select="$endDate" />
              </Data>
            </Cell>
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
          </Row>
          <Row>
            <Cell ss:MergeAcross="22" ss:StyleID="m63075037572">
              <Data ss:Type="String">
                Отделения:  <xsl:value-of select="$departmentCollection" />
              </Data>
            </Cell>
            <Cell ss:StyleID="s25" />
            <Cell ss:StyleID="s25" />
            <Cell ss:StyleID="s25" />
            <Cell ss:StyleID="s25" />
            <Cell ss:StyleID="s25" />
            <Cell ss:StyleID="s25" />
            <Cell ss:StyleID="s25" />
          </Row>
          <Row>
            <Cell ss:MergeDown="3" ss:StyleID="s79">
              <Data ss:Type="String">Профіль ліжок</Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m63075038572">
              <Data ss:Type="String">Код</Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m63075037472">
              <Data ss:Type="String">Фактично розгорнуто ліжок, включно ліжка, згорнуті на ремонт на кінець звітного періоду</Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m63075037492">
              <Data ss:Type="String">Середньомісячних (годових) ліжок</Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m63075038512">
              <Data ss:Type="String">Перебувало хворих на початок звітнього періоду</Data>
            </Cell>
            <Cell ss:MergeAcross="3" ss:MergeDown="1" ss:StyleID="s77">
              <Data
                ss:Type="String">
                Поступило хворих (без переведених всередені лікарні)
              </Data>
            </Cell>
            <Cell ss:MergeAcross="2" ss:MergeDown="1" ss:StyleID="s77">
              <Data
                ss:Type="String">
                Переведено хворих всередені лікарні
              </Data>
            </Cell>
            <Cell ss:MergeAcross="2" ss:MergeDown="1" ss:StyleID="s77">
              <Data
                ss:Type="String">
                Виписано хворих
              </Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:MergeDown="1" ss:StyleID="s77">
              <Data
                ss:Type="String">
                Померло
              </Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:MergeDown="1" ss:StyleID="s77">
              <Data
                ss:Type="String">
                Перебувало хворих
              </Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:MergeDown="1" ss:StyleID="s78">
              <Data
                ss:Type="String">
                Виконувано койкоднів
              </Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m63075042672">
              <Data ss:Type="String">Число койкоднів згортання на ремонт</Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m63075042692">
              <Data ss:Type="String">Проведено койкоднів матерями при дітях </Data>
            </Cell>
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="41.25">
            <Cell ss:Index="24" ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
          </Row>
          <Row ss:AutoFitHeight="0">
            <Cell ss:Index="6" ss:MergeDown="1" ss:StyleID="m63075040880">
              <Data
                ss:Type="String">
                всього
              </Data>
            </Cell>
            <Cell ss:MergeAcross="2" ss:StyleID="m63075040940">
              <Data ss:Type="String">із них</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075040960">
              <Data ss:Type="String">з інших відділень</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075040980">
              <Data ss:Type="String">в інші відділення</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075042880">
              <Data ss:Type="String"> у тому числі до суток</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075040860">
              <Data ss:Type="String">всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075042772">
              <Data ss:Type="String">у т.ч. переведені в інші стаціонари</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075038592">
              <Data ss:Type="String"> у тому числі до суток</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="s72">
              <Data ss:Type="String">всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075040900">
              <Data ss:Type="String">у тому числі до суток</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075040920">
              <Data ss:Type="String">всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m63075042712">
              <Data ss:Type="String">у т.ч. сільских жителів</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="s73">
              <Data ss:Type="String">Всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="s75">
              <Data ss:Type="String">сільскими жителями</Data>
            </Cell>
            <Cell ss:Index="24" ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="176.25">
            <Cell ss:Index="7" ss:StyleID="s21">
              <Data ss:Type="String">сільских  жителів</Data>
            </Cell>
            <Cell ss:StyleID="s21">
              <Data ss:Type="String">дітей до 17 років включно</Data>
            </Cell>
            <Cell ss:StyleID="s21">
              <Data ss:Type="String">дітей до 14 років включно</Data>
            </Cell>
            <Cell ss:Index="24" ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
          </Row>
          <Row>
            <Cell ss:StyleID="s66">
              <Data ss:Type="String">А</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="String">Б</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">1</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">2</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">3</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">4</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">5</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">6</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="String">6a</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">7</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">8</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="String">8а</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">9</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">10</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="String">10а</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">11</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="String">11а</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">12</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="String">12а</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">13</Data>
            </Cell>
            <Cell ss:StyleID="s66">
              <Data ss:Type="Number">14</Data>
            </Cell>
            <Cell ss:StyleID="s67">
              <Data ss:Type="Number">15</Data>
            </Cell>
            <Cell ss:StyleID="s68">
              <Data ss:Type="Number">16</Data>
            </Cell>
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
            <Cell ss:StyleID="s22" />
          </Row>
          <xsl:for-each select="NewDataSet/DataItem">
            <Row>
              <Cell ss:StyleID="s176">
                <Data ss:Type="String">
                  <xsl:value-of select="@DepartmentName_a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@Code_b" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@ExpandedBeds_1" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@MonthlyAverageBeds_2" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@WereSickFromTheBeginOfPeriod_3" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AdmissionCount_4" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AdmissionVillagerCount_5" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AgeLessThan17Count_6" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AgeLessThan14Count_6a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredFromOtherDepartments_7" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredToOtherDepartments_8" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredPriorToDay_8a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DischargeCount_9" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DischargeTransferredToOtherHospitals_10" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DischargePriorToDayCount_10a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DeathCount_11" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DeathPriorToDayCount_11a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@WereSickCount_12" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@WereSickVillagerCount_12a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@PerformedDaybed_13" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@PerformedDaybedVillager_14" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DaybedRolledOnRepairCount_15" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s105">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DaybedMothersWithChildren_16" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s22" />
              <Cell ss:StyleID="s22" />
              <Cell ss:StyleID="s22" />
              <Cell ss:StyleID="s22" />
              <Cell ss:StyleID="s22" />
              <Cell ss:StyleID="s22" />
              <Cell ss:StyleID="s22" />
            </Row>
          </xsl:for-each>
        </Table>
        <WorksheetOptions xmlns="urn:schemas-microsoft-com:office:excel">
          <PageSetup>
            <Layout x:Orientation="Landscape" />
          </PageSetup>
          <Print>
            <ValidPrinterInfo />
            <PaperSizeIndex>9</PaperSizeIndex>
            <Scale>58</Scale>
            <HorizontalResolution>600</HorizontalResolution>
            <VerticalResolution>600</VerticalResolution>
          </Print>
          <Selected />
          <Panes>
            <Pane>
              <Number>3</Number>
              <ActiveRow>6</ActiveRow>
              <RangeSelection>R7C1:R7C23</RangeSelection>
            </Pane>
          </Panes>
          <ProtectObjects>False</ProtectObjects>
          <ProtectScenarios>False</ProtectScenarios>
        </WorksheetOptions>
      </Worksheet>
      <Worksheet ss:Name="Лист2">
        <Table ss:ExpandedColumnCount="1" ss:ExpandedRowCount="1" x:FullColumns="1"
               x:FullRows="1">
        </Table>
        <WorksheetOptions xmlns="urn:schemas-microsoft-com:office:excel">
          <ProtectObjects>False</ProtectObjects>
          <ProtectScenarios>False</ProtectScenarios>
        </WorksheetOptions>
      </Worksheet>
      <Worksheet ss:Name="Лист3">
        <Table ss:ExpandedColumnCount="1" ss:ExpandedRowCount="1" x:FullColumns="1"
               x:FullRows="1">
        </Table>
        <WorksheetOptions xmlns="urn:schemas-microsoft-com:office:excel">
          <ProtectObjects>False</ProtectObjects>
          <ProtectScenarios>False</ProtectScenarios>
        </WorksheetOptions>
      </Worksheet>
    </Workbook>
  </xsl:template>
</xsl:stylesheet>