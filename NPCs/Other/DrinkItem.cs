using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x02000314 RID: 788
	public class DrinkItem : MonoBehaviour
	{
		// Token: 0x06003A97 RID: 14999 RVA: 0x00132924 File Offset: 0x00130B24
		// Note: this type is marked as 'beforefieldinit'.
		static DrinkItem()
		{
			Il2CppClassPointerStore<DrinkItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "DrinkItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr);
			DrinkItem.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "Npc");
			DrinkItem.NativeFieldInfoPtr_DrinkPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "DrinkPrefab");
			DrinkItem.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "<active>k__BackingField");
			DrinkItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100670203);
			DrinkItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100670204);
			DrinkItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100670205);
			DrinkItem.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100670206);
			DrinkItem.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100670207);
			DrinkItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100670208);
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06003A98 RID: 15000 RVA: 0x00132A08 File Offset: 0x00130C08
		// (set) Token: 0x06003A99 RID: 15001 RVA: 0x00132A44 File Offset: 0x00130C44
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00132A84 File Offset: 0x00130C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147368, XrefRangeEnd = 147376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00132AB8 File Offset: 0x00130CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147376, XrefRangeEnd = 147382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x00132AEC File Offset: 0x00130CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147382, XrefRangeEnd = 147390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x00132B20 File Offset: 0x00130D20
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrinkItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x0001DE4A File Offset: 0x0001C04A
		public DrinkItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x00132B5C File Offset: 0x00130D5C
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x0001DE53 File Offset: 0x0001C053
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x00132B8C File Offset: 0x00130D8C
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x0001DE72 File Offset: 0x0001C072
		public unsafe AvatarEquippable DrinkPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_DrinkPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_DrinkPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x00132BBC File Offset: 0x00130DBC
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x0001DE91 File Offset: 0x0001C091
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeFieldInfoPtr_DrinkPrefab;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
