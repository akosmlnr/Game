using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000713 RID: 1811
	public class SaveExportButton : MonoBehaviour
	{
		// Token: 0x0600A135 RID: 41269 RVA: 0x0028D7E0 File Offset: 0x0028B9E0
		// Note: this type is marked as 'beforefieldinit'.
		static SaveExportButton()
		{
			Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SaveExportButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr);
			SaveExportButton.NativeFieldInfoPtr_SaveSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, "SaveSlotIndex");
			SaveExportButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100683169);
			SaveExportButton.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100683170);
			SaveExportButton.NativeMethodInfoPtr_ShowSaveFileDialog_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100683171);
			SaveExportButton.NativeMethodInfoPtr_ZipSaveFolder_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100683172);
			SaveExportButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr, 100683173);
		}

		// Token: 0x0600A136 RID: 41270 RVA: 0x0028D888 File Offset: 0x0028BA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284856, XrefRangeEnd = 284867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A137 RID: 41271 RVA: 0x0028D8BC File Offset: 0x0028BABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284867, XrefRangeEnd = 284927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x0028D8F0 File Offset: 0x0028BAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284927, XrefRangeEnd = 284951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ShowSaveFileDialog(string fileName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr_ShowSaveFileDialog_Public_Static_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x0028D92C File Offset: 0x0028BB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284951, XrefRangeEnd = 284954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZipSaveFolder(string sourceFolderPath, string destinationZipPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFolderPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationZipPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr_ZipSaveFolder_Public_Static_Void_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x0028D974 File Offset: 0x0028BB74
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveExportButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveExportButton>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveExportButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x0004EDA5 File Offset: 0x0004CFA5
		public SaveExportButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600A13C RID: 41276 RVA: 0x0028D9B0 File Offset: 0x0028BBB0
		// (set) Token: 0x0600A13D RID: 41277 RVA: 0x0004EDAE File Offset: 0x0004CFAE
		public unsafe int SaveSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveExportButton.NativeFieldInfoPtr_SaveSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveExportButton.NativeFieldInfoPtr_SaveSlotIndex)) = value;
			}
		}

		// Token: 0x04006C33 RID: 27699
		private static readonly IntPtr NativeFieldInfoPtr_SaveSlotIndex;

		// Token: 0x04006C34 RID: 27700
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006C35 RID: 27701
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04006C36 RID: 27702
		private static readonly IntPtr NativeMethodInfoPtr_ShowSaveFileDialog_Public_Static_String_String_0;

		// Token: 0x04006C37 RID: 27703
		private static readonly IntPtr NativeMethodInfoPtr_ZipSaveFolder_Public_Static_Void_String_String_0;

		// Token: 0x04006C38 RID: 27704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
