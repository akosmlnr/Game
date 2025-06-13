using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000714 RID: 1812
	public class SaveImportButton : MonoBehaviour
	{
		// Token: 0x0600A13E RID: 41278 RVA: 0x0028D9D8 File Offset: 0x0028BBD8
		// Note: this type is marked as 'beforefieldinit'.
		static SaveImportButton()
		{
			Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SaveImportButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr);
			SaveImportButton.NativeFieldInfoPtr_ImportScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, "ImportScreen");
			SaveImportButton.NativeFieldInfoPtr_ParentScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, "ParentScreen");
			SaveImportButton.NativeFieldInfoPtr_SaveSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, "SaveSlotIndex");
			SaveImportButton.NativeMethodInfoPtr_get_TempImportPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100683174);
			SaveImportButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100683175);
			SaveImportButton.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100683176);
			SaveImportButton.NativeMethodInfoPtr_UnzipSaveFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100683177);
			SaveImportButton.NativeMethodInfoPtr_ShowOpenFileDialog_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100683178);
			SaveImportButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr, 100683179);
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600A13F RID: 41279 RVA: 0x0028DABC File Offset: 0x0028BCBC
		public unsafe static string TempImportPath
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 284965, RefRangeEnd = 284968, XrefRangeStart = 284954, XrefRangeEnd = 284965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_get_TempImportPath_Public_Static_get_String_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x0028DAE8 File Offset: 0x0028BCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284968, XrefRangeEnd = 284979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x0028DB1C File Offset: 0x0028BD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284979, XrefRangeEnd = 285034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x0028DB50 File Offset: 0x0028BD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285034, XrefRangeEnd = 285047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnzipSaveFile(string zipFilePath, string destinationFolderPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(zipFilePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationFolderPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_UnzipSaveFile_Public_Static_Void_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x0028DB98 File Offset: 0x0028BD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285047, XrefRangeEnd = 285071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ShowOpenFileDialog()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr_ShowOpenFileDialog_Public_Static_String_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x0028DBC4 File Offset: 0x0028BDC4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveImportButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveImportButton>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveImportButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x0004EDC9 File Offset: 0x0004CFC9
		public SaveImportButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600A146 RID: 41286 RVA: 0x0028DC00 File Offset: 0x0028BE00
		// (set) Token: 0x0600A147 RID: 41287 RVA: 0x0004EDD2 File Offset: 0x0004CFD2
		public unsafe ImportScreen ImportScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_ImportScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImportScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_ImportScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600A148 RID: 41288 RVA: 0x0028DC30 File Offset: 0x0028BE30
		// (set) Token: 0x0600A149 RID: 41289 RVA: 0x0004EDF1 File Offset: 0x0004CFF1
		public unsafe MainMenuScreen ParentScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_ParentScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_ParentScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600A14A RID: 41290 RVA: 0x0028DC60 File Offset: 0x0028BE60
		// (set) Token: 0x0600A14B RID: 41291 RVA: 0x0004EE10 File Offset: 0x0004D010
		public unsafe int SaveSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_SaveSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveImportButton.NativeFieldInfoPtr_SaveSlotIndex)) = value;
			}
		}

		// Token: 0x04006C39 RID: 27705
		private static readonly IntPtr NativeFieldInfoPtr_ImportScreen;

		// Token: 0x04006C3A RID: 27706
		private static readonly IntPtr NativeFieldInfoPtr_ParentScreen;

		// Token: 0x04006C3B RID: 27707
		private static readonly IntPtr NativeFieldInfoPtr_SaveSlotIndex;

		// Token: 0x04006C3C RID: 27708
		private static readonly IntPtr NativeMethodInfoPtr_get_TempImportPath_Public_Static_get_String_0;

		// Token: 0x04006C3D RID: 27709
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006C3E RID: 27710
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04006C3F RID: 27711
		private static readonly IntPtr NativeMethodInfoPtr_UnzipSaveFile_Public_Static_Void_String_String_0;

		// Token: 0x04006C40 RID: 27712
		private static readonly IntPtr NativeMethodInfoPtr_ShowOpenFileDialog_Public_Static_String_0;

		// Token: 0x04006C41 RID: 27713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
