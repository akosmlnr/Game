using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000725 RID: 1829
	public class CharacterCreatorColor : CharacterCreatorField<Color>
	{
		// Token: 0x0600A336 RID: 41782 RVA: 0x00293764 File Offset: 0x00291964
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorColor()
		{
			Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr);
			CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "ClothingColorsToUse");
			CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "OptionContainer");
			CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "UseClothingColors");
			CharacterCreatorColor.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "Colors");
			CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "OptionPrefab");
			CharacterCreatorColor.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "optionButtons");
			CharacterCreatorColor.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "selectedButton");
			CharacterCreatorColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100683356);
			CharacterCreatorColor.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100683357);
			CharacterCreatorColor.NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100683358);
			CharacterCreatorColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100683359);
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x00293870 File Offset: 0x00291A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287114, XrefRangeEnd = 287173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x002938AC File Offset: 0x00291AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287173, XrefRangeEnd = 287197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorColor.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x002938E8 File Offset: 0x00291AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287197, XrefRangeEnd = 287208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionClicked(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x00293928 File Offset: 0x00291B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287208, XrefRangeEnd = 287218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x000500BC File Offset: 0x0004E2BC
		public CharacterCreatorColor(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600A33C RID: 41788 RVA: 0x00293964 File Offset: 0x00291B64
		// (set) Token: 0x0600A33D RID: 41789 RVA: 0x000500C5 File Offset: 0x0004E2C5
		public unsafe static Il2CppStructArray<EClothingColor> ClothingColorsToUse
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<EClothingColor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600A33E RID: 41790 RVA: 0x0029398C File Offset: 0x00291B8C
		// (set) Token: 0x0600A33F RID: 41791 RVA: 0x000500D7 File Offset: 0x0004E2D7
		public unsafe RectTransform OptionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600A340 RID: 41792 RVA: 0x002939BC File Offset: 0x00291BBC
		// (set) Token: 0x0600A341 RID: 41793 RVA: 0x000500F6 File Offset: 0x0004E2F6
		public unsafe bool UseClothingColors
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors)) = value;
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600A342 RID: 41794 RVA: 0x002939E4 File Offset: 0x00291BE4
		// (set) Token: 0x0600A343 RID: 41795 RVA: 0x00050111 File Offset: 0x0004E311
		public unsafe List<Color> Colors
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_Colors);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600A344 RID: 41796 RVA: 0x00293A14 File Offset: 0x00291C14
		// (set) Token: 0x0600A345 RID: 41797 RVA: 0x00050130 File Offset: 0x0004E330
		public unsafe GameObject OptionPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600A346 RID: 41798 RVA: 0x00293A44 File Offset: 0x00291C44
		// (set) Token: 0x0600A347 RID: 41799 RVA: 0x0005014F File Offset: 0x0004E34F
		public unsafe List<Button> optionButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_optionButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600A348 RID: 41800 RVA: 0x00293A74 File Offset: 0x00291C74
		// (set) Token: 0x0600A349 RID: 41801 RVA: 0x0005016E File Offset: 0x0004E36E
		public unsafe Button selectedButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_selectedButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D70 RID: 28016
		private static readonly System.IntPtr NativeFieldInfoPtr_ClothingColorsToUse;

		// Token: 0x04006D71 RID: 28017
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006D72 RID: 28018
		private static readonly System.IntPtr NativeFieldInfoPtr_UseClothingColors;

		// Token: 0x04006D73 RID: 28019
		private static readonly System.IntPtr NativeFieldInfoPtr_Colors;

		// Token: 0x04006D74 RID: 28020
		private static readonly System.IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006D75 RID: 28021
		private static readonly System.IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006D76 RID: 28022
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x04006D77 RID: 28023
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006D78 RID: 28024
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006D79 RID: 28025
		private static readonly System.IntPtr NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0;

		// Token: 0x04006D7A RID: 28026
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFC RID: 3068
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorColor+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E21C RID: 57884 RVA: 0x00359340 File Offset: 0x00357540
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr);
				CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, "col");
				CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, 100683361);
				CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, 100683362);
			}

			// Token: 0x0600E21D RID: 57885 RVA: 0x003593BC File Offset: 0x003575BC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E21E RID: 57886 RVA: 0x003593F8 File Offset: 0x003575F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287112, XrefRangeEnd = 287114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E21F RID: 57887 RVA: 0x0006DDAF File Offset: 0x0006BFAF
			public __c__DisplayClass7_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C5 RID: 17861
			// (get) Token: 0x0600E220 RID: 57888 RVA: 0x0035942C File Offset: 0x0035762C
			// (set) Token: 0x0600E221 RID: 57889 RVA: 0x0006DDB8 File Offset: 0x0006BFB8
			public unsafe Color col
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col)) = value;
				}
			}

			// Token: 0x170045C6 RID: 17862
			// (get) Token: 0x0600E222 RID: 57890 RVA: 0x00359454 File Offset: 0x00357654
			// (set) Token: 0x0600E223 RID: 57891 RVA: 0x0006DDD3 File Offset: 0x0006BFD3
			public unsafe CharacterCreatorColor __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorColor>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009799 RID: 38809
			private static readonly System.IntPtr NativeFieldInfoPtr_col;

			// Token: 0x0400979A RID: 38810
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400979B RID: 38811
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400979C RID: 38812
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
