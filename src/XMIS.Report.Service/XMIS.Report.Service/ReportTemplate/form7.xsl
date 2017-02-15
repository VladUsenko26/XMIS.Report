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
        <Author>Microsoft Corporation</Author>
        <LastAuthor>amizyumskaya</LastAuthor>
        <LastPrinted>2006-01-10T17:48:18Z</LastPrinted>
        <Created>1996-10-08T23:32:33Z</Created>
        <LastSaved>2016-04-29T12:07:37Z</LastSaved>
        <Version>15.00</Version>
      </DocumentProperties>
      <OfficeDocumentSettings xmlns="urn:schemas-microsoft-com:office:office">
        <AllowPNG />
      </OfficeDocumentSettings>
      <ExcelWorkbook xmlns="urn:schemas-microsoft-com:office:excel">
        <WindowHeight>7755</WindowHeight>
        <WindowWidth>20490</WindowWidth>
        <WindowTopX>0</WindowTopX>
        <WindowTopY>0</WindowTopY>
        <ProtectStructure>False</ProtectStructure>
        <ProtectWindows>False</ProtectWindows>
      </ExcelWorkbook>
      <Styles>
        <Style ss:ID="Default" ss:Name="Normal">
          <Alignment ss:Vertical="Bottom" />
          <Borders />
          <Font ss:FontName="Arial" />
          <Interior />
          <NumberFormat />
          <Protection />
        </Style>
        <Style ss:ID="m552322331904">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="8" />
        </Style>
        <Style ss:ID="m552322331924">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="8" />
        </Style>
        <Style ss:ID="m552322331984">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="m552322332004">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="m552322332024">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="m552322322128">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Bold="1" />
        </Style>
        <Style ss:ID="m552322322148">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="12"
                ss:Bold="1" />
        </Style>
        <Style ss:ID="m552322322168">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322322228">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322322268">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322322288">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322322308">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322331508">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="12"
                ss:Bold="1" />
          <Interior ss:Color="#C0C0C0" ss:Pattern="Solid" />
        </Style>
        <Style ss:ID="m552322331528">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Bold="1" />
        </Style>
        <Style ss:ID="m552322331548">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="m552322331568">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322331608">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322331628">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322331648">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322331668">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322323456">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Bold="1" />
        </Style>
        <Style ss:ID="m552322323476">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322323496">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322323516">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322332736">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322332756">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322332776">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322332796">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322332816">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322332836">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322332876">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322332896">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322324624">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322324644">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322324664">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322324684">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322324704">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="m552322324724">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s23">
          <Borders />
        </Style>
        <Style ss:ID="s24">
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="s25">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior />
        </Style>
        <Style ss:ID="s26">
          <Alignment ss:Vertical="Bottom" />
          <Borders />
        </Style>
        <Style ss:ID="s27">
          <Borders />
          <Interior />
        </Style>
        <Style ss:ID="s28">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior ss:Color="#FFFF00" ss:Pattern="Solid" />
        </Style>
        <Style ss:ID="s34">
          <Alignment ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="s35">
          <Alignment ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
        </Style>
        <Style ss:ID="s36">
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s37">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90"
                     ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s38">
          <Alignment ss:Horizontal="Justify" ss:Vertical="Top" ss:WrapText="1" />
          <Borders />
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="12"
                ss:Bold="1" />
          <Interior />
        </Style>
        <Style ss:ID="s39">
          <Alignment ss:Horizontal="Justify" ss:Vertical="Top" ss:WrapText="1" />
          <Borders />
          <Font ss:FontName="Times New Roman" x:CharSet="204" x:Family="Roman"
                ss:Size="12" />
          <Interior />
        </Style>
        <Style ss:ID="s40">
          <Alignment ss:Horizontal="Justify" ss:Vertical="Top" ss:WrapText="1" />
          <Borders />
          <Font ss:FontName="Times New Roman" x:CharSet="204" x:Family="Roman"
                ss:Size="16" />
          <Interior />
        </Style>
        <Style ss:ID="s41">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior ss:Color="#C0C0C0" ss:Pattern="Solid" />
        </Style>
        <Style ss:ID="s42">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Interior ss:Color="#C0C0C0" ss:Pattern="Solid" />
        </Style>
        <Style ss:ID="s91">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" ss:Rotate="90" />
          <Borders>
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s97">
          <Alignment ss:Horizontal="Center" ss:Vertical="Center" ss:WrapText="1" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s99">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders />
        </Style>
        <Style ss:ID="s103">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" ss:Size="12" />
        </Style>
        <Style ss:ID="s183">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="14" />
          <Interior />
        </Style>
        <Style ss:ID="s184">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="14" />
          <Interior ss:Color="#FFFF00" ss:Pattern="Solid" />
        </Style>
        <Style ss:ID="s185">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="14" />
          <Interior ss:Color="#C0C0C0" ss:Pattern="Solid" />
        </Style>
        <Style ss:ID="s186">
          <Alignment ss:Horizontal="Center" ss:Vertical="Bottom" />
          <Borders>
            <Border ss:Position="Bottom" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Left" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Right" ss:LineStyle="Continuous" ss:Weight="1" />
            <Border ss:Position="Top" ss:LineStyle="Continuous" ss:Weight="1" />
          </Borders>
          <Font ss:FontName="Arial" x:CharSet="204" x:Family="Swiss" ss:Size="14" />
          <Interior ss:Color="#C0C0C0" ss:Pattern="Solid" />
        </Style>
      </Styles>
      <Worksheet ss:Name="Лист3">
        <Table ss:ExpandedColumnCount="51" x:FullColumns="1"
               x:FullRows="1">
          <Column ss:Width="170.25"/>
          <Column ss:AutoFitWidth="0" ss:Width="34.5" />
          <Column ss:AutoFitWidth="0" ss:Width="54" />
          <Column ss:AutoFitWidth="0" ss:Width="33.75" />
          <Column ss:AutoFitWidth="0" ss:Width="40.5" />
          <Column ss:AutoFitWidth="0" ss:Width="39.75" />
          <Column ss:AutoFitWidth="0" ss:Width="39" />
          <Column ss:AutoFitWidth="0" ss:Width="47.25" />
          <Column ss:AutoFitWidth="0" ss:Width="35.25" />
          <Column ss:AutoFitWidth="0" ss:Width="30.75" />
          <Column ss:AutoFitWidth="0" ss:Width="36" />
          <Column ss:AutoFitWidth="0" ss:Width="39" />
          <Column ss:AutoFitWidth="0" ss:Width="39.75" />
          <Column ss:AutoFitWidth="0" ss:Width="42" />
          <Column ss:AutoFitWidth="0" ss:Width="37.5" />
          <Column ss:AutoFitWidth="0" ss:Width="35.25" />
          <Column ss:AutoFitWidth="0" ss:Width="38.25" />
          <Column ss:AutoFitWidth="0" ss:Width="42.75" />
          <Column ss:AutoFitWidth="0" ss:Width="43.5" />
          <Column ss:AutoFitWidth="0" ss:Width="36.75" />
          <Column ss:AutoFitWidth="0" ss:Width="47.25" />
          <Column ss:AutoFitWidth="0" ss:Width="39" />
          <Column ss:AutoFitWidth="0" ss:Width="39.75" />
          <Column ss:AutoFitWidth="0" ss:Width="36.75" />
          <Column ss:AutoFitWidth="0" ss:Width="37.5" />
          <Column ss:AutoFitWidth="0" ss:Width="54" />
          <Column ss:AutoFitWidth="0" ss:Width="57.75" />
          <Column ss:AutoFitWidth="0" ss:Width="56.25" ss:Span="1" />
          <Row>
            <Cell ss:StyleID="s23" />
            <Cell ss:Index="10" ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:MergeAcross="5" ss:StyleID="s99">
              <Data ss:Type="String">                            </Data>
            </Cell>
            <Cell ss:StyleID="s23" />
            <Cell ss:Index="21" ss:StyleID="s26">
              <Data ss:Type="String"> </Data>
            </Cell>
            <Cell ss:MergeAcross="3" ss:StyleID="s99" />
            <Cell ss:MergeAcross="3" ss:StyleID="m552322331984">
              <Data ss:Type="String">Код форми за ЗКУД</Data>
            </Cell>
          </Row>
          <Row>
            <Cell ss:StyleID="s23" />
            <Cell ss:Index="10" ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:MergeAcross="5" ss:StyleID="s99">
              <Data ss:Type="String">                          </Data>
            </Cell>
            <Cell ss:StyleID="s23" />
            <Cell ss:Index="21" ss:StyleID="s26" />
            <Cell ss:MergeAcross="3" ss:StyleID="s99" />
            <Cell ss:MergeAcross="3" ss:StyleID="m552322332004">
              <Data ss:Type="String">Код закладу за ЗКПО</Data>
            </Cell>
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="4.5">
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s24" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
            <Cell ss:StyleID="s23" />
          </Row>
          <Row ss:AutoFitHeight="0">
            <Cell ss:MergeAcross="2" ss:StyleID="m552322331904">
              <Data ss:Type="String">Міністерство охорони здоров'я України</Data>
            </Cell>
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:StyleID="s34" />
            <Cell ss:MergeAcross="3" ss:StyleID="m552322332024" />
            <Cell ss:MergeAcross="3" ss:StyleID="m552322331924">
              <Data ss:Type="String">МЕДИЧНА ДОКУМЕНТАЦІЯ</Data>
            </Cell>
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="16.5">
            <Cell ss:MergeAcross="2" ss:StyleID="m552322323456">
              <Data ss:Type="String">
                <xsl:value-of select="$hospital" />
              </Data>
            </Cell>
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:StyleID="s35" />
            <Cell ss:MergeAcross="4" ss:StyleID="m552322331548" />
            <Cell ss:MergeAcross="3" ss:StyleID="m552322331528">
              <Data ss:Type="String">ФОРМА № 007/У</Data>
            </Cell>
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="16.5">
            <Cell ss:MergeAcross="28" ss:StyleID="m552322322148">
              <Data ss:Type="String">
                Дані з обліку руху хворих і ліжкового фонду стаціонару за
                <xsl:value-of select="$startDate" />
              </Data>
            </Cell>
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="17.25">
            <Cell ss:MergeAcross="28" ss:StyleID="m552322322128">
              <Data ss:Type="String">Отделения:<xsl:value-of select="$departmentCollection" /></Data>
            </Cell>
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="34.5">
            <Cell ss:MergeDown="3" ss:StyleID="m552322322288">
              <Data ss:Type="String">Профіль ліжок</Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m552322332836">
              <Data ss:Type="String">Код</Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m552322323476">
              <Data ss:Type="String">Фактично розгорнуто ліжок, включно ліжка, згорнуті на ремонт</Data>
            </Cell>
            <Cell ss:MergeDown="3" ss:StyleID="m552322323516">
              <Data ss:Type="String">у тому числі ліжка, згорнуті на ремонт</Data>
            </Cell>
            <Cell ss:MergeAcross="11" ss:StyleID="s103">
              <Data ss:Type="String">Рух хворих за минулу добу</Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:StyleID="m552322324724">
              <Data ss:Type="String">На початок поточн. дня</Data>
            </Cell>
            <Cell ss:MergeAcross="10" ss:StyleID="m552322331508">
              <Data ss:Type="String">З початку місяця</Data>
            </Cell>
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="60">
            <Cell ss:Index="5" ss:MergeDown="2" ss:StyleID="m552322323496">
              <Data
                ss:Type="String">
                перебувало хворихна початок минулої доби
              </Data>
            </Cell>
            <Cell ss:MergeAcross="2" ss:StyleID="s97">
              <Data ss:Type="String">Поступило хворих (без переведених всередені лікарні)</Data>
            </Cell>
            <Cell ss:MergeAcross="2" ss:StyleID="s97">
              <Data ss:Type="String">Переведено хворих всередені лікарні</Data>
            </Cell>
            <Cell ss:MergeAcross="2" ss:StyleID="s97">
              <Data ss:Type="String">Виписано хворих</Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:StyleID="s97">
              <Data ss:Type="String">Померло</Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:StyleID="s97">
              <Data ss:Type="String">Перебувало хворих</Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:StyleID="s97">
              <Data ss:Type="String">Поступило хворих </Data>
            </Cell>
            <Cell ss:MergeAcross="2" ss:StyleID="m552322324664">
              <Data ss:Type="String">Переведено</Data>
            </Cell>
            <Cell ss:MergeDown="2" ss:StyleID="m552322324624">
              <Data ss:Type="String">Виписано хворих</Data>
            </Cell>
            <Cell ss:MergeDown="2" ss:StyleID="m552322331648">
              <Data ss:Type="String">Померло</Data>
            </Cell>
            <Cell ss:MergeDown="2" ss:StyleID="m552322331568">
              <Data ss:Type="String">План койкоднів</Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:StyleID="m552322322168">
              <Data ss:Type="String">Виконувано койкоднів </Data>
            </Cell>
            <Cell ss:MergeDown="2" ss:StyleID="s91">
              <Data ss:Type="String">Виконувано койкоднів(%)</Data>
            </Cell>
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
          </Row>
          <Row ss:Height="15">
            <Cell ss:Index="6" ss:MergeDown="1" ss:StyleID="m552322322308">
              <Data
                ss:Type="String">
                всього
              </Data>
            </Cell>
            <Cell ss:MergeAcross="1" ss:StyleID="s103">
              <Data ss:Type="String">із них</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322332736">
              <Data ss:Type="String">з інших відділень</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322322228">
              <Data ss:Type="String">в інші відділення</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322332876">
              <Data ss:Type="String"> у тому числі до суток</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322332896">
              <Data ss:Type="String">всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322324704">
              <Data ss:Type="String">у т.ч. переведені в інші стаціонари</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322332796">
              <Data ss:Type="String"> у тому числі до суток</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322332816">
              <Data ss:Type="String">всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322322268">
              <Data ss:Type="String">у тому числі до суток</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322332756">
              <Data ss:Type="String">всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322332776">
              <Data ss:Type="String">у т.ч. сільских жителів</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322331608">
              <Data ss:Type="String">Всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322331628">
              <Data ss:Type="String"> сільских жителів</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322324644">
              <Data ss:Type="String">із інших відділень</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322331668">
              <Data ss:Type="String">в інші відділення</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="m552322324684">
              <Data ss:Type="String">у тому числі до суток</Data>
            </Cell>
            <Cell ss:Index="27" ss:MergeDown="1" ss:StyleID="s91">
              <Data ss:Type="String">Всього</Data>
            </Cell>
            <Cell ss:MergeDown="1" ss:StyleID="s37">
              <Data ss:Type="String">сільскими жителями</Data>
            </Cell>
            <Cell ss:Index="30" ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="197.25">
            <Cell ss:Index="7" ss:StyleID="s37">
              <Data ss:Type="String">сільских жителів</Data>
            </Cell>
            <Cell ss:StyleID="s37">
              <Data ss:Type="String">дітей до 17 років включно</Data>
            </Cell>
            <Cell ss:Index="30" ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
            <Cell ss:StyleID="s36" />
          </Row>
          <Row ss:AutoFitHeight="0" ss:Height="15.75">
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">1</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">2</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">3</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">4</Data>
            </Cell>
            <Cell ss:StyleID="s28">
              <Data ss:Type="Number">5</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">6</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">7</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">8</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">9</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">10</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="String">10а</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">11</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">12</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="String">12а</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">13</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="String">13а</Data>
            </Cell>
            <Cell ss:StyleID="s28">
              <Data ss:Type="Number">14</Data>
            </Cell>
            <Cell ss:StyleID="s25">
              <Data ss:Type="Number">15</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">16</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">17</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">18</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">19</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">20</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">21</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">22</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">23</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">24</Data>
            </Cell>
            <Cell ss:StyleID="s41">
              <Data ss:Type="Number">25</Data>
            </Cell>
            <Cell ss:StyleID="s42">
              <Data ss:Type="Number">26</Data>
            </Cell>
          </Row>
          <xsl:for-each select="NewDataSet/DataItem">
            <Row ss:Height="18">
              <Cell ss:StyleID="s183">
                <Data ss:Type="String">
                  <xsl:value-of select="@DepartmentName_1" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@Code_2" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@ExpandedBeds_3" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@RolledToRepairBeds_4" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s184">
                <Data ss:Type="Number">
                  <xsl:value-of select="@PatientsAtTheBeginningOfTheLastDay_5" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AdmissionForThePastDayCount_6" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AdmissionVillagerForThePastDayCount_7" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AgeLessThan17ForThePastDayCount_8" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredFromOtherDepartmentsForThePastDay_9" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredToOtherDepartmentsForThePastDay_10" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredPriorToDayForThePastDay_10a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DischargeForThePastDayCount_11" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DischargeTransferredToOtherHospitals_12" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DischargePriorToDayForThePastDayCount_12a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DeathForThePastDayCount_13" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DeathPriorToDayCount_13a" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s184">
                <Data ss:Type="Number">
                  <xsl:value-of select="@WereSickCount_14" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s183">
                <Data ss:Type="Number">
                  <xsl:value-of select="@WereSickVillagerCount_15" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s185">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AdmissionFromTheBeginOfTheMonthCount_16" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s185">
                <Data ss:Type="Number">
                  <xsl:value-of select="@AdmissionVillagerFromTheBeginOfTheMonthCount_17" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s185">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredFromOtherDepartmentsFromTheBeginOfTheMonth_18" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s185">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredToOtherDepartmentsFromTheBeginOfTheMonth_19" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s185">
                <Data ss:Type="Number">
                  <xsl:value-of select="@TransferredPriorToDayFromTheBeginOfTheMonth_20" />
                </Data>
              </Cell>

              <Cell ss:StyleID="s185">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DischargeFromTheBeginOfTheMonthCount_21" />
                </Data>
              </Cell>
              <Cell ss:StyleID="s185">
                <Data ss:Type="Number">
                  <xsl:value-of select="@DeathFromTheBeginOfTheMonthCount_22" />
                </Data>
              </Cell>

              <Cell ss:StyleID="s185" />
              <Cell ss:StyleID="s185" >
                <Data ss:Type="Number">
                  <xsl:value-of select="@DaybedFromTheBeginOfTheMonth_24" />
                </Data>
              </Cell>
              
              <Cell ss:StyleID="s185" >
                <Data ss:Type="Number">
                  <xsl:value-of select="@DaybedVillagerFromTheBeginOfTheMonth_25" />
                </Data>
              </Cell>
            
              <Cell ss:StyleID="s186" />
            </Row>
          </xsl:for-each>
        </Table>
        <WorksheetOptions xmlns="urn:schemas-microsoft-com:office:excel">
          <PageSetup>
            <Layout x:Orientation="Landscape" />
            <Header x:Margin="0.51181102362204722" />
            <Footer x:Margin="0.51181102362204722" />
            <PageMargins x:Bottom="0.98425196850393704" x:Left="0.76"
                         x:Right="0.78740157480314965" x:Top="0.98425196850393704" />
          </PageSetup>
          <FitToPage />
          <Print>
            <ValidPrinterInfo />
            <Scale>52</Scale>
            <HorizontalResolution>600</HorizontalResolution>
            <VerticalResolution>600</VerticalResolution>
          </Print>
          <Zoom>70</Zoom>
          <PageBreakZoom>60</PageBreakZoom>
          <Selected />
          <Panes>
            <Pane>
              <Number>3</Number>
              <ActiveRow>19</ActiveRow>
              <ActiveCol>18</ActiveCol>
            </Pane>
          </Panes>
          <ProtectObjects>False</ProtectObjects>
          <ProtectScenarios>False</ProtectScenarios>
        </WorksheetOptions>
      </Worksheet>
    </Workbook>
  </xsl:template>
</xsl:stylesheet>