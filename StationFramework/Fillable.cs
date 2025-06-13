using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005AA RID: 1450
	public class Fillable : MonoBehaviour
	{
		// Token: 0x06007EBF RID: 32447 RVA: 0x00222858 File Offset: 0x00220A58
		// Note: this type is marked as 'beforefieldinit'.
		static Fillable()
		{
			Il2CppClassPointerStore<Fillable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "Fillable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable>.NativeClassPtr);
			Fillable.NativeFieldInfoPtr__contents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<contents>k__BackingField");
			Fillable.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "LiquidContainer");
			Fillable.NativeFieldInfoPtr_FillableEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "FillableEnabled");
			Fillable.NativeFieldInfoPtr_LiquidCapacity_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "LiquidCapacity_L");
			Fillable.NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679265);
			Fillable.NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679266);
			Fillable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679267);
			Fillable.NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679268);
			Fillable.NativeMethodInfoPtr_ResetContents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679269);
			Fillable.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679270);
			Fillable.NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679271);
			Fillable.NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679272);
			Fillable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100679273);
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x0022298C File Offset: 0x00220B8C
		// (set) Token: 0x06007EC1 RID: 32449 RVA: 0x002229CC File Offset: 0x00220BCC
		public unsafe List<Fillable.Content> contents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Fillable.Content>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007EC2 RID: 32450 RVA: 0x00222A10 File Offset: 0x00220C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241208, XrefRangeEnd = 241210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EC3 RID: 32451 RVA: 0x00222A44 File Offset: 0x00220C44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 241237, RefRangeEnd = 241240, XrefRangeStart = 241210, XrefRangeEnd = 241237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLiquid(string label, float volume, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref volume;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EC4 RID: 32452 RVA: 0x00222AA4 File Offset: 0x00220CA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 241244, RefRangeEnd = 241250, XrefRangeStart = 241240, XrefRangeEnd = 241244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_ResetContents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x00222AD8 File Offset: 0x00220CD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241285, RefRangeEnd = 241287, XrefRangeStart = 241250, XrefRangeEnd = 241285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EC6 RID: 32454 RVA: 0x00222B0C File Offset: 0x00220D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241287, XrefRangeEnd = 241301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLiquidVolume(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x00222B5C File Offset: 0x00220D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241319, RefRangeEnd = 241320, XrefRangeStart = 241301, XrefRangeEnd = 241319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalLiquidVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x00222B98 File Offset: 0x00220D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241320, XrefRangeEnd = 241328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fillable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EC9 RID: 32457 RVA: 0x0003BEA1 File Offset: 0x0003A0A1
		public Fillable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06007ECA RID: 32458 RVA: 0x00222BD4 File Offset: 0x00220DD4
		// (set) Token: 0x06007ECB RID: 32459 RVA: 0x0003BEAA File Offset: 0x0003A0AA
		public unsafe List<Fillable.Content> _contents_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr__contents_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Fillable.Content>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr__contents_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x06007ECC RID: 32460 RVA: 0x00222C04 File Offset: 0x00220E04
		// (set) Token: 0x06007ECD RID: 32461 RVA: 0x0003BEC9 File Offset: 0x0003A0C9
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x06007ECE RID: 32462 RVA: 0x00222C34 File Offset: 0x00220E34
		// (set) Token: 0x06007ECF RID: 32463 RVA: 0x0003BEE8 File Offset: 0x0003A0E8
		public unsafe bool FillableEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_FillableEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_FillableEnabled)) = value;
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x06007ED0 RID: 32464 RVA: 0x00222C5C File Offset: 0x00220E5C
		// (set) Token: 0x06007ED1 RID: 32465 RVA: 0x0003BF03 File Offset: 0x0003A103
		public unsafe float LiquidCapacity_L
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidCapacity_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidCapacity_L)) = value;
			}
		}

		// Token: 0x0400564E RID: 22094
		private static readonly System.IntPtr NativeFieldInfoPtr__contents_k__BackingField;

		// Token: 0x0400564F RID: 22095
		private static readonly System.IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x04005650 RID: 22096
		private static readonly System.IntPtr NativeFieldInfoPtr_FillableEnabled;

		// Token: 0x04005651 RID: 22097
		private static readonly System.IntPtr NativeFieldInfoPtr_LiquidCapacity_L;

		// Token: 0x04005652 RID: 22098
		private static readonly System.IntPtr NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0;

		// Token: 0x04005653 RID: 22099
		private static readonly System.IntPtr NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0;

		// Token: 0x04005654 RID: 22100
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005655 RID: 22101
		private static readonly System.IntPtr NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0;

		// Token: 0x04005656 RID: 22102
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetContents_Public_Void_0;

		// Token: 0x04005657 RID: 22103
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLiquid_Private_Void_0;

		// Token: 0x04005658 RID: 22104
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0;

		// Token: 0x04005659 RID: 22105
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0;

		// Token: 0x0400565A RID: 22106
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B03 RID: 2819
		public class Content : Il2CppSystem.Object
		{
			// Token: 0x0600D8DC RID: 55516 RVA: 0x0033EC8C File Offset: 0x0033CE8C
			// Note: this type is marked as 'beforefieldinit'.
			static Content()
			{
				Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "Content");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr);
				Fillable.Content.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Label");
				Fillable.Content.NativeFieldInfoPtr_Volume_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Volume_L");
				Fillable.Content.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Color");
				Fillable.Content.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, 100679274);
			}

			// Token: 0x0600D8DD RID: 55517 RVA: 0x0033ED08 File Offset: 0x0033CF08
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Content() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.Content.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8DE RID: 55518 RVA: 0x00069409 File Offset: 0x00067609
			public Content(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F1 RID: 17137
			// (get) Token: 0x0600D8DF RID: 55519 RVA: 0x0033ED44 File Offset: 0x0033CF44
			// (set) Token: 0x0600D8E0 RID: 55520 RVA: 0x00069412 File Offset: 0x00067612
			public unsafe string Label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170042F2 RID: 17138
			// (get) Token: 0x0600D8E1 RID: 55521 RVA: 0x0033ED6C File Offset: 0x0033CF6C
			// (set) Token: 0x0600D8E2 RID: 55522 RVA: 0x00069431 File Offset: 0x00067631
			public unsafe float Volume_L
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Volume_L);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Volume_L)) = value;
				}
			}

			// Token: 0x170042F3 RID: 17139
			// (get) Token: 0x0600D8E3 RID: 55523 RVA: 0x0033ED94 File Offset: 0x0033CF94
			// (set) Token: 0x0600D8E4 RID: 55524 RVA: 0x0006944C File Offset: 0x0006764C
			public unsafe Color Color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04009222 RID: 37410
			private static readonly System.IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04009223 RID: 37411
			private static readonly System.IntPtr NativeFieldInfoPtr_Volume_L;

			// Token: 0x04009224 RID: 37412
			private static readonly System.IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04009225 RID: 37413
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B04 RID: 2820
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D8E5 RID: 55525 RVA: 0x0033EDBC File Offset: 0x0033CFBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr);
				Fillable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9");
				Fillable.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9__11_0");
				Fillable.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9__13_0");
				Fillable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100679276);
				Fillable.__c.NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100679277);
				Fillable.__c.NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100679278);
			}

			// Token: 0x0600D8E6 RID: 55526 RVA: 0x0033EE60 File Offset: 0x0033D060
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8E7 RID: 55527 RVA: 0x0033EE9C File Offset: 0x0033D09C
			[CallerCount(0)]
			public unsafe float _UpdateLiquid_b__11_0(Fillable.Content x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D8E8 RID: 55528 RVA: 0x0033EEEC File Offset: 0x0033D0EC
			[CallerCount(0)]
			public unsafe float _GetTotalLiquidVolume_b__13_0(Fillable.Content x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D8E9 RID: 55529 RVA: 0x00069467 File Offset: 0x00067667
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F4 RID: 17140
			// (get) Token: 0x0600D8EA RID: 55530 RVA: 0x0033EF3C File Offset: 0x0033D13C
			// (set) Token: 0x0600D8EB RID: 55531 RVA: 0x00069470 File Offset: 0x00067670
			public unsafe static Fillable.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F5 RID: 17141
			// (get) Token: 0x0600D8EC RID: 55532 RVA: 0x0033EF64 File Offset: 0x0033D164
			// (set) Token: 0x0600D8ED RID: 55533 RVA: 0x00069482 File Offset: 0x00067682
			public unsafe static Il2CppSystem.Func<Fillable.Content, float> __9__11_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Fillable.Content, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F6 RID: 17142
			// (get) Token: 0x0600D8EE RID: 55534 RVA: 0x0033EF8C File Offset: 0x0033D18C
			// (set) Token: 0x0600D8EF RID: 55535 RVA: 0x00069494 File Offset: 0x00067694
			public unsafe static Il2CppSystem.Func<Fillable.Content, float> __9__13_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Fillable.Content, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009226 RID: 37414
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009227 RID: 37415
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009228 RID: 37416
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009229 RID: 37417
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400922A RID: 37418
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0;

			// Token: 0x0400922B RID: 37419
			private static readonly System.IntPtr NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0;
		}

		// Token: 0x02000B05 RID: 2821
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D8F0 RID: 55536 RVA: 0x0033EFB4 File Offset: 0x0033D1B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr);
				Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, "totalVolume");
				Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, 100679279);
				Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, 100679280);
			}

			// Token: 0x0600D8F1 RID: 55537 RVA: 0x0033F01C File Offset: 0x0033D21C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8F2 RID: 55538 RVA: 0x0033F058 File Offset: 0x0033D258
			[CallerCount(0)]
			public unsafe Color _UpdateLiquid_b__1(Color acc, Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref acc;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D8F3 RID: 55539 RVA: 0x000694A6 File Offset: 0x000676A6
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F7 RID: 17143
			// (get) Token: 0x0600D8F4 RID: 55540 RVA: 0x0033F0B4 File Offset: 0x0033D2B4
			// (set) Token: 0x0600D8F5 RID: 55541 RVA: 0x000694AF File Offset: 0x000676AF
			public unsafe float totalVolume
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume)) = value;
				}
			}

			// Token: 0x0400922C RID: 37420
			private static readonly System.IntPtr NativeFieldInfoPtr_totalVolume;

			// Token: 0x0400922D RID: 37421
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400922E RID: 37422
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0;
		}

		// Token: 0x02000B06 RID: 2822
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D8F6 RID: 55542 RVA: 0x0033F0DC File Offset: 0x0033D2DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr);
				Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, "label");
				Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, 100679281);
				Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, 100679282);
			}

			// Token: 0x0600D8F7 RID: 55543 RVA: 0x0033F144 File Offset: 0x0033D344
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8F8 RID: 55544 RVA: 0x0033F180 File Offset: 0x0033D380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLiquidVolume_b__0(Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D8F9 RID: 55545 RVA: 0x000694CA File Offset: 0x000676CA
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F8 RID: 17144
			// (get) Token: 0x0600D8FA RID: 55546 RVA: 0x0033F1D0 File Offset: 0x0033D3D0
			// (set) Token: 0x0600D8FB RID: 55547 RVA: 0x000694D3 File Offset: 0x000676D3
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400922F RID: 37423
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009230 RID: 37424
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009231 RID: 37425
			private static readonly System.IntPtr NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0;
		}

		// Token: 0x02000B07 RID: 2823
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D8FC RID: 55548 RVA: 0x0033F1F8 File Offset: 0x0033D3F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr);
				Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, "label");
				Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, 100679283);
				Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, 100679284);
			}

			// Token: 0x0600D8FD RID: 55549 RVA: 0x0033F260 File Offset: 0x0033D460
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8FE RID: 55550 RVA: 0x0033F29C File Offset: 0x0033D49C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddLiquid_b__0(Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D8FF RID: 55551 RVA: 0x000694F2 File Offset: 0x000676F2
			public __c__DisplayClass9_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F9 RID: 17145
			// (get) Token: 0x0600D900 RID: 55552 RVA: 0x0033F2EC File Offset: 0x0033D4EC
			// (set) Token: 0x0600D901 RID: 55553 RVA: 0x000694FB File Offset: 0x000676FB
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009232 RID: 37426
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009233 RID: 37427
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009234 RID: 37428
			private static readonly System.IntPtr NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0;
		}
	}
}
