using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Settings;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x02000716 RID: 1814
	public class SettingsScreen : MainMenuScreen
	{
		// Token: 0x0600A166 RID: 41318 RVA: 0x0028E1B4 File Offset: 0x0028C3B4
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsScreen()
		{
			Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SettingsScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr);
			SettingsScreen.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "Categories");
			SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ApplyDisplayButton");
			SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "ConfirmDisplaySettings");
			SettingsScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100683190);
			SettingsScreen.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100683191);
			SettingsScreen.NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100683192);
			SettingsScreen.NativeMethodInfoPtr_DisplayChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100683193);
			SettingsScreen.NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100683194);
			SettingsScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, 100683195);
		}

		// Token: 0x0600A167 RID: 41319 RVA: 0x0028E298 File Offset: 0x0028C498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285233, XrefRangeEnd = 285244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x0028E2D4 File Offset: 0x0028C4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285244, XrefRangeEnd = 285260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x0028E308 File Offset: 0x0028C508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285263, RefRangeEnd = 285265, XrefRangeStart = 285260, XrefRangeEnd = 285263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCategory(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x0028E348 File Offset: 0x0028C548
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 285268, RefRangeEnd = 285275, XrefRangeStart = 285265, XrefRangeEnd = 285268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_DisplayChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x0028E37C File Offset: 0x0028C57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285275, XrefRangeEnd = 285289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDisplaySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x0028E3B0 File Offset: 0x0028C5B0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x0004EEFC File Offset: 0x0004D0FC
		public SettingsScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600A16E RID: 41326 RVA: 0x0028E3EC File Offset: 0x0028C5EC
		// (set) Token: 0x0600A16F RID: 41327 RVA: 0x0004EF05 File Offset: 0x0004D105
		public unsafe Il2CppReferenceArray<SettingsScreen.SettingsCategory> Categories
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Categories);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SettingsScreen.SettingsCategory>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600A170 RID: 41328 RVA: 0x0028E41C File Offset: 0x0028C61C
		// (set) Token: 0x0600A171 RID: 41329 RVA: 0x0004EF24 File Offset: 0x0004D124
		public unsafe Button ApplyDisplayButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ApplyDisplayButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600A172 RID: 41330 RVA: 0x0028E44C File Offset: 0x0028C64C
		// (set) Token: 0x0600A173 RID: 41331 RVA: 0x0004EF43 File Offset: 0x0004D143
		public unsafe ConfirmDisplaySettings ConfirmDisplaySettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmDisplaySettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.NativeFieldInfoPtr_ConfirmDisplaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C53 RID: 27731
		private static readonly System.IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04006C54 RID: 27732
		private static readonly System.IntPtr NativeFieldInfoPtr_ApplyDisplayButton;

		// Token: 0x04006C55 RID: 27733
		private static readonly System.IntPtr NativeFieldInfoPtr_ConfirmDisplaySettings;

		// Token: 0x04006C56 RID: 27734
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006C57 RID: 27735
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04006C58 RID: 27736
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowCategory_Public_Void_Int32_0;

		// Token: 0x04006C59 RID: 27737
		private static readonly System.IntPtr NativeMethodInfoPtr_DisplayChanged_Public_Void_0;

		// Token: 0x04006C5A RID: 27738
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDisplaySettings_Private_Void_0;

		// Token: 0x04006C5B RID: 27739
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BEF RID: 3055
		[System.Serializable]
		public class SettingsCategory : Il2CppSystem.Object
		{
			// Token: 0x0600E1B3 RID: 57779 RVA: 0x0035815C File Offset: 0x0035635C
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsCategory()
			{
				Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "SettingsCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr);
				SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, "Button");
				SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, "Panel");
				SettingsScreen.SettingsCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr, 100683196);
			}

			// Token: 0x0600E1B4 RID: 57780 RVA: 0x003581C4 File Offset: 0x003563C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.SettingsCategory>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.SettingsCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1B5 RID: 57781 RVA: 0x0006DA03 File Offset: 0x0006BC03
			public SettingsCategory(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A2 RID: 17826
			// (get) Token: 0x0600E1B6 RID: 57782 RVA: 0x00358200 File Offset: 0x00356400
			// (set) Token: 0x0600E1B7 RID: 57783 RVA: 0x0006DA0C File Offset: 0x0006BC0C
			public unsafe Button Button
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045A3 RID: 17827
			// (get) Token: 0x0600E1B8 RID: 57784 RVA: 0x00358230 File Offset: 0x00356430
			// (set) Token: 0x0600E1B9 RID: 57785 RVA: 0x0006DA2B File Offset: 0x0006BC2B
			public unsafe GameObject Panel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.SettingsCategory.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009751 RID: 38737
			private static readonly System.IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x04009752 RID: 38738
			private static readonly System.IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x04009753 RID: 38739
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BF0 RID: 3056
		[ObfuscatedName("ScheduleOne.UI.MainMenu.SettingsScreen+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E1BA RID: 57786 RVA: 0x00358260 File Offset: 0x00356460
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsScreen>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr);
				SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, "index");
				SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, 100683197);
				SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr, 100683198);
			}

			// Token: 0x0600E1BB RID: 57787 RVA: 0x003582DC File Offset: 0x003564DC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsScreen.__c__DisplayClass5_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1BC RID: 57788 RVA: 0x00358318 File Offset: 0x00356518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285231, XrefRangeEnd = 285233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsScreen.__c__DisplayClass5_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1BD RID: 57789 RVA: 0x0006DA4A File Offset: 0x0006BC4A
			public __c__DisplayClass5_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A4 RID: 17828
			// (get) Token: 0x0600E1BE RID: 57790 RVA: 0x0035834C File Offset: 0x0035654C
			// (set) Token: 0x0600E1BF RID: 57791 RVA: 0x0006DA53 File Offset: 0x0006BC53
			public unsafe int index
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170045A5 RID: 17829
			// (get) Token: 0x0600E1C0 RID: 57792 RVA: 0x00358374 File Offset: 0x00356574
			// (set) Token: 0x0600E1C1 RID: 57793 RVA: 0x0006DA6E File Offset: 0x0006BC6E
			public unsafe SettingsScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsScreen.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009754 RID: 38740
			private static readonly System.IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009755 RID: 38741
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009756 RID: 38742
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009757 RID: 38743
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
