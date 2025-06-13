using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000728 RID: 1832
	public class CharacterCreatorOptionList : CharacterCreatorField<string>
	{
		// Token: 0x0600A369 RID: 41833 RVA: 0x002941A8 File Offset: 0x002923A8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorOptionList()
		{
			Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorOptionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr);
			CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "OptionContainer");
			CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "CanSelectNone");
			CharacterCreatorOptionList.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "Options");
			CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "OptionPrefab");
			CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "optionButtons");
			CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "selectedButton");
			CharacterCreatorOptionList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100683377);
			CharacterCreatorOptionList.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100683378);
			CharacterCreatorOptionList.NativeMethodInfoPtr_OptionClicked_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100683379);
			CharacterCreatorOptionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100683380);
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x002942A0 File Offset: 0x002924A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287280, XrefRangeEnd = 287338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorOptionList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x002942DC File Offset: 0x002924DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287338, XrefRangeEnd = 287365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorOptionList.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x00294318 File Offset: 0x00292518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287365, XrefRangeEnd = 287384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionClicked(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.NativeMethodInfoPtr_OptionClicked_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x0029435C File Offset: 0x0029255C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287384, XrefRangeEnd = 287394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorOptionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x00050274 File Offset: 0x0004E474
		public CharacterCreatorOptionList(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600A36F RID: 41839 RVA: 0x00294398 File Offset: 0x00292598
		// (set) Token: 0x0600A370 RID: 41840 RVA: 0x0005027D File Offset: 0x0004E47D
		public unsafe RectTransform OptionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600A371 RID: 41841 RVA: 0x002943C8 File Offset: 0x002925C8
		// (set) Token: 0x0600A372 RID: 41842 RVA: 0x0005029C File Offset: 0x0004E49C
		public unsafe bool CanSelectNone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone)) = value;
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600A373 RID: 41843 RVA: 0x002943F0 File Offset: 0x002925F0
		// (set) Token: 0x0600A374 RID: 41844 RVA: 0x000502B7 File Offset: 0x0004E4B7
		public unsafe List<CharacterCreatorOptionList.Option> Options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_Options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterCreatorOptionList.Option>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600A375 RID: 41845 RVA: 0x00294420 File Offset: 0x00292620
		// (set) Token: 0x0600A376 RID: 41846 RVA: 0x000502D6 File Offset: 0x0004E4D6
		public unsafe GameObject OptionPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600A377 RID: 41847 RVA: 0x00294450 File Offset: 0x00292650
		// (set) Token: 0x0600A378 RID: 41848 RVA: 0x000502F5 File Offset: 0x0004E4F5
		public unsafe List<Button> optionButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600A379 RID: 41849 RVA: 0x00294480 File Offset: 0x00292680
		// (set) Token: 0x0600A37A RID: 41850 RVA: 0x00050314 File Offset: 0x0004E514
		public unsafe Button selectedButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D8E RID: 28046
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006D8F RID: 28047
		private static readonly System.IntPtr NativeFieldInfoPtr_CanSelectNone;

		// Token: 0x04006D90 RID: 28048
		private static readonly System.IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04006D91 RID: 28049
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006D92 RID: 28050
		private static readonly System.IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006D93 RID: 28051
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x04006D94 RID: 28052
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006D95 RID: 28053
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006D96 RID: 28054
		private static readonly System.IntPtr NativeMethodInfoPtr_OptionClicked_Public_Void_String_0;

		// Token: 0x04006D97 RID: 28055
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFE RID: 3070
		[System.Serializable]
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600E22D RID: 57901 RVA: 0x00359610 File Offset: 0x00357810
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr);
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "Label");
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "AssetPath");
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "ClothingItemEquivalent");
				CharacterCreatorOptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, 100683381);
			}

			// Token: 0x0600E22E RID: 57902 RVA: 0x0035968C File Offset: 0x0035788C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E22F RID: 57903 RVA: 0x0006DE39 File Offset: 0x0006C039
			public Option(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C9 RID: 17865
			// (get) Token: 0x0600E230 RID: 57904 RVA: 0x003596C8 File Offset: 0x003578C8
			// (set) Token: 0x0600E231 RID: 57905 RVA: 0x0006DE42 File Offset: 0x0006C042
			public unsafe string Label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045CA RID: 17866
			// (get) Token: 0x0600E232 RID: 57906 RVA: 0x003596F0 File Offset: 0x003578F0
			// (set) Token: 0x0600E233 RID: 57907 RVA: 0x0006DE61 File Offset: 0x0006C061
			public unsafe string AssetPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045CB RID: 17867
			// (get) Token: 0x0600E234 RID: 57908 RVA: 0x00359718 File Offset: 0x00357918
			// (set) Token: 0x0600E235 RID: 57909 RVA: 0x0006DE80 File Offset: 0x0006C080
			public unsafe ClothingDefinition ClothingItemEquivalent
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097A2 RID: 38818
			private static readonly System.IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x040097A3 RID: 38819
			private static readonly System.IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x040097A4 RID: 38820
			private static readonly System.IntPtr NativeFieldInfoPtr_ClothingItemEquivalent;

			// Token: 0x040097A5 RID: 38821
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BFF RID: 3071
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E236 RID: 57910 RVA: 0x00359748 File Offset: 0x00357948
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr);
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, "option");
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, 100683382);
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, 100683383);
			}

			// Token: 0x0600E237 RID: 57911 RVA: 0x003597C4 File Offset: 0x003579C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E238 RID: 57912 RVA: 0x00359800 File Offset: 0x00357A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287261, XrefRangeEnd = 287280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E239 RID: 57913 RVA: 0x0006DE9F File Offset: 0x0006C09F
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045CC RID: 17868
			// (get) Token: 0x0600E23A RID: 57914 RVA: 0x00359834 File Offset: 0x00357A34
			// (set) Token: 0x0600E23B RID: 57915 RVA: 0x0006DEA8 File Offset: 0x0006C0A8
			public unsafe string option
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045CD RID: 17869
			// (get) Token: 0x0600E23C RID: 57916 RVA: 0x0035985C File Offset: 0x00357A5C
			// (set) Token: 0x0600E23D RID: 57917 RVA: 0x0006DEC7 File Offset: 0x0006C0C7
			public unsafe CharacterCreatorOptionList __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorOptionList>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097A6 RID: 38822
			private static readonly System.IntPtr NativeFieldInfoPtr_option;

			// Token: 0x040097A7 RID: 38823
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097A8 RID: 38824
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097A9 RID: 38825
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}

		// Token: 0x02000C00 RID: 3072
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E23E RID: 57918 RVA: 0x0035988C File Offset: 0x00357A8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr);
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, "option");
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, 100683384);
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, 100683385);
			}

			// Token: 0x0600E23F RID: 57919 RVA: 0x003598F4 File Offset: 0x00357AF4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E240 RID: 57920 RVA: 0x00359930 File Offset: 0x00357B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OptionClicked_b__0(CharacterCreatorOptionList.Option o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E241 RID: 57921 RVA: 0x0006DEE6 File Offset: 0x0006C0E6
			public __c__DisplayClass9_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045CE RID: 17870
			// (get) Token: 0x0600E242 RID: 57922 RVA: 0x00359980 File Offset: 0x00357B80
			// (set) Token: 0x0600E243 RID: 57923 RVA: 0x0006DEEF File Offset: 0x0006C0EF
			public unsafe string option
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040097AA RID: 38826
			private static readonly System.IntPtr NativeFieldInfoPtr_option;

			// Token: 0x040097AB RID: 38827
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097AC RID: 38828
			private static readonly System.IntPtr NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0;
		}
	}
}
