using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ExtendedComponents;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000715 RID: 1813
	public class SetupScreen : MainMenuScreen
	{
		// Token: 0x0600A14C RID: 41292 RVA: 0x0028DC88 File Offset: 0x0028BE88
		// Note: this type is marked as 'beforefieldinit'.
		static SetupScreen()
		{
			Il2CppClassPointerStore<SetupScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SetupScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr);
			SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "DEFAULT_SAVE_PATH");
			SetupScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "InputField");
			SetupScreen.NativeFieldInfoPtr_StartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "StartButton");
			SetupScreen.NativeFieldInfoPtr_SkipIntroContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "SkipIntroContainer");
			SetupScreen.NativeFieldInfoPtr_SkipIntroToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "SkipIntroToggle");
			SetupScreen.NativeFieldInfoPtr_NotHostWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "NotHostWarning");
			SetupScreen.NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "slotIndex");
			SetupScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683180);
			SetupScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683181);
			SetupScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683182);
			SetupScreen.NativeMethodInfoPtr_StartGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683183);
			SetupScreen.NativeMethodInfoPtr_IsInputValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683184);
			SetupScreen.NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683185);
			SetupScreen.NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683186);
			SetupScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683187);
			SetupScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683188);
			SetupScreen.NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100683189);
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x0028DE0C File Offset: 0x0028C00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285071, XrefRangeEnd = 285083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A14E RID: 41294 RVA: 0x0028DE48 File Offset: 0x0028C048
		[CallerCount(0)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A14F RID: 41295 RVA: 0x0028DE88 File Offset: 0x0028C088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285083, XrefRangeEnd = 285096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A150 RID: 41296 RVA: 0x0028DEBC File Offset: 0x0028C0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285178, RefRangeEnd = 285179, XrefRangeStart = 285096, XrefRangeEnd = 285178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_StartGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A151 RID: 41297 RVA: 0x0028DEF0 File Offset: 0x0028C0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285179, XrefRangeEnd = 285180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInputValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_IsInputValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x0028DF2C File Offset: 0x0028C12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285180, XrefRangeEnd = 285189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFolderContents(string folderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x0028DF70 File Offset: 0x0028C170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285214, RefRangeEnd = 285215, XrefRangeStart = 285189, XrefRangeEnd = 285214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyDefaultSaveToFolder(string folderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x0028DFB4 File Offset: 0x0028C1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285215, XrefRangeEnd = 285230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x0028DFFC File Offset: 0x0028C1FC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x0028E038 File Offset: 0x0028C238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285230, XrefRangeEnd = 285231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__7_0(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A157 RID: 41303 RVA: 0x0004EE2B File Offset: 0x0004D02B
		public SetupScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600A158 RID: 41304 RVA: 0x0028E07C File Offset: 0x0028C27C
		// (set) Token: 0x0600A159 RID: 41305 RVA: 0x0004EE34 File Offset: 0x0004D034
		public unsafe static string DEFAULT_SAVE_PATH
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600A15A RID: 41306 RVA: 0x0028E09C File Offset: 0x0028C29C
		// (set) Token: 0x0600A15B RID: 41307 RVA: 0x0004EE46 File Offset: 0x0004D046
		public unsafe GameInputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600A15C RID: 41308 RVA: 0x0028E0CC File Offset: 0x0028C2CC
		// (set) Token: 0x0600A15D RID: 41309 RVA: 0x0004EE65 File Offset: 0x0004D065
		public unsafe Button StartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_StartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_StartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600A15E RID: 41310 RVA: 0x0028E0FC File Offset: 0x0028C2FC
		// (set) Token: 0x0600A15F RID: 41311 RVA: 0x0004EE84 File Offset: 0x0004D084
		public unsafe RectTransform SkipIntroContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600A160 RID: 41312 RVA: 0x0028E12C File Offset: 0x0028C32C
		// (set) Token: 0x0600A161 RID: 41313 RVA: 0x0004EEA3 File Offset: 0x0004D0A3
		public unsafe Toggle SkipIntroToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600A162 RID: 41314 RVA: 0x0028E15C File Offset: 0x0028C35C
		// (set) Token: 0x0600A163 RID: 41315 RVA: 0x0004EEC2 File Offset: 0x0004D0C2
		public unsafe RectTransform NotHostWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_NotHostWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_NotHostWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600A164 RID: 41316 RVA: 0x0028E18C File Offset: 0x0028C38C
		// (set) Token: 0x0600A165 RID: 41317 RVA: 0x0004EEE1 File Offset: 0x0004D0E1
		public unsafe int slotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_slotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_slotIndex)) = value;
			}
		}

		// Token: 0x04006C42 RID: 27714
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SAVE_PATH;

		// Token: 0x04006C43 RID: 27715
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006C44 RID: 27716
		private static readonly IntPtr NativeFieldInfoPtr_StartButton;

		// Token: 0x04006C45 RID: 27717
		private static readonly IntPtr NativeFieldInfoPtr_SkipIntroContainer;

		// Token: 0x04006C46 RID: 27718
		private static readonly IntPtr NativeFieldInfoPtr_SkipIntroToggle;

		// Token: 0x04006C47 RID: 27719
		private static readonly IntPtr NativeFieldInfoPtr_NotHostWarning;

		// Token: 0x04006C48 RID: 27720
		private static readonly IntPtr NativeFieldInfoPtr_slotIndex;

		// Token: 0x04006C49 RID: 27721
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006C4A RID: 27722
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x04006C4B RID: 27723
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006C4C RID: 27724
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Public_Void_0;

		// Token: 0x04006C4D RID: 27725
		private static readonly IntPtr NativeMethodInfoPtr_IsInputValid_Private_Boolean_0;

		// Token: 0x04006C4E RID: 27726
		private static readonly IntPtr NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0;

		// Token: 0x04006C4F RID: 27727
		private static readonly IntPtr NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0;

		// Token: 0x04006C50 RID: 27728
		private static readonly IntPtr NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0;

		// Token: 0x04006C51 RID: 27729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006C52 RID: 27730
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0;
	}
}
