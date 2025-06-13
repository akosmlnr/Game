using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x0200070C RID: 1804
	public class ImportScreen : MainMenuScreen
	{
		// Token: 0x0600A0D1 RID: 41169 RVA: 0x0028C528 File Offset: 0x0028A728
		// Note: this type is marked as 'beforefieldinit'.
		static ImportScreen()
		{
			Il2CppClassPointerStore<ImportScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ImportScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr);
			ImportScreen.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "MainContainer");
			ImportScreen.NativeFieldInfoPtr_FailContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "FailContainer");
			ImportScreen.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "ConfirmButton");
			ImportScreen.NativeFieldInfoPtr_OrganisationNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "OrganisationNameLabel");
			ImportScreen.NativeFieldInfoPtr_NetworthLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "NetworthLabel");
			ImportScreen.NativeFieldInfoPtr_VersionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "VersionLabel");
			ImportScreen.NativeFieldInfoPtr_WarningLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "WarningLabel");
			ImportScreen.NativeFieldInfoPtr_slotToOverwrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "slotToOverwrite");
			ImportScreen.NativeFieldInfoPtr_saveInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, "saveInfo");
			ImportScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_MainMenuScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100683128);
			ImportScreen.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100683129);
			ImportScreen.NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100683130);
			ImportScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100683131);
			ImportScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr, 100683132);
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x0028C670 File Offset: 0x0028A870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284467, RefRangeEnd = 284468, XrefRangeStart = 284432, XrefRangeEnd = 284467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int _slotToOverwrite, MainMenuScreen previousScreen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _slotToOverwrite;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previousScreen);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_MainMenuScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x0028C6C0 File Offset: 0x0028A8C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284468, RefRangeEnd = 284470, XrefRangeStart = 284468, XrefRangeEnd = 284468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x0028C6F4 File Offset: 0x0028A8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284470, XrefRangeEnd = 284510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x0028C728 File Offset: 0x0028A928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284510, XrefRangeEnd = 284525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x0028C770 File Offset: 0x0028A970
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImportScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImportScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImportScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x0004EA53 File Offset: 0x0004CC53
		public ImportScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0600A0D8 RID: 41176 RVA: 0x0028C7AC File Offset: 0x0028A9AC
		// (set) Token: 0x0600A0D9 RID: 41177 RVA: 0x0004EA5C File Offset: 0x0004CC5C
		public unsafe GameObject MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0600A0DA RID: 41178 RVA: 0x0028C7DC File Offset: 0x0028A9DC
		// (set) Token: 0x0600A0DB RID: 41179 RVA: 0x0004EA7B File Offset: 0x0004CC7B
		public unsafe GameObject FailContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_FailContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_FailContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0600A0DC RID: 41180 RVA: 0x0028C80C File Offset: 0x0028AA0C
		// (set) Token: 0x0600A0DD RID: 41181 RVA: 0x0004EA9A File Offset: 0x0004CC9A
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600A0DE RID: 41182 RVA: 0x0028C83C File Offset: 0x0028AA3C
		// (set) Token: 0x0600A0DF RID: 41183 RVA: 0x0004EAB9 File Offset: 0x0004CCB9
		public unsafe TextMeshProUGUI OrganisationNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_OrganisationNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_OrganisationNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600A0E0 RID: 41184 RVA: 0x0028C86C File Offset: 0x0028AA6C
		// (set) Token: 0x0600A0E1 RID: 41185 RVA: 0x0004EAD8 File Offset: 0x0004CCD8
		public unsafe TextMeshProUGUI NetworthLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_NetworthLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_NetworthLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600A0E2 RID: 41186 RVA: 0x0028C89C File Offset: 0x0028AA9C
		// (set) Token: 0x0600A0E3 RID: 41187 RVA: 0x0004EAF7 File Offset: 0x0004CCF7
		public unsafe TextMeshProUGUI VersionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_VersionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_VersionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600A0E4 RID: 41188 RVA: 0x0028C8CC File Offset: 0x0028AACC
		// (set) Token: 0x0600A0E5 RID: 41189 RVA: 0x0004EB16 File Offset: 0x0004CD16
		public unsafe TextMeshProUGUI WarningLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_WarningLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_WarningLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600A0E6 RID: 41190 RVA: 0x0028C8FC File Offset: 0x0028AAFC
		// (set) Token: 0x0600A0E7 RID: 41191 RVA: 0x0004EB35 File Offset: 0x0004CD35
		public unsafe int slotToOverwrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_slotToOverwrite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_slotToOverwrite)) = value;
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600A0E8 RID: 41192 RVA: 0x0028C924 File Offset: 0x0028AB24
		// (set) Token: 0x0600A0E9 RID: 41193 RVA: 0x0004EB50 File Offset: 0x0004CD50
		public unsafe SaveInfo saveInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_saveInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImportScreen.NativeFieldInfoPtr_saveInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BF8 RID: 27640
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x04006BF9 RID: 27641
		private static readonly IntPtr NativeFieldInfoPtr_FailContainer;

		// Token: 0x04006BFA RID: 27642
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x04006BFB RID: 27643
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationNameLabel;

		// Token: 0x04006BFC RID: 27644
		private static readonly IntPtr NativeFieldInfoPtr_NetworthLabel;

		// Token: 0x04006BFD RID: 27645
		private static readonly IntPtr NativeFieldInfoPtr_VersionLabel;

		// Token: 0x04006BFE RID: 27646
		private static readonly IntPtr NativeFieldInfoPtr_WarningLabel;

		// Token: 0x04006BFF RID: 27647
		private static readonly IntPtr NativeFieldInfoPtr_slotToOverwrite;

		// Token: 0x04006C00 RID: 27648
		private static readonly IntPtr NativeFieldInfoPtr_saveInfo;

		// Token: 0x04006C01 RID: 27649
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_MainMenuScreen_0;

		// Token: 0x04006C02 RID: 27650
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04006C03 RID: 27651
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;

		// Token: 0x04006C04 RID: 27652
		private static readonly IntPtr NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0;

		// Token: 0x04006C05 RID: 27653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
