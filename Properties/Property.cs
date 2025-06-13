using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001FA RID: 506
	public class Property : ScriptableObject
	{
		// Token: 0x060028BC RID: 10428 RVA: 0x000F4468 File Offset: 0x000F2668
		// Note: this type is marked as 'beforefieldinit'.
		static Property()
		{
			Il2CppClassPointerStore<Property>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Property");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property>.NativeClassPtr);
			Property.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Name");
			Property.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Description");
			Property.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ID");
			Property.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Tier");
			Property.NativeFieldInfoPtr_Addictiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Addictiveness");
			Property.NativeFieldInfoPtr_ProductColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ProductColor");
			Property.NativeFieldInfoPtr_LabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "LabelColor");
			Property.NativeFieldInfoPtr_ImplementedPriorMixingRework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ImplementedPriorMixingRework");
			Property.NativeFieldInfoPtr_ValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ValueChange");
			Property.NativeFieldInfoPtr_ValueMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ValueMultiplier");
			Property.NativeFieldInfoPtr_AddBaseValueMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "AddBaseValueMultiple");
			Property.NativeFieldInfoPtr_MixDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "MixDirection");
			Property.NativeFieldInfoPtr_MixMagnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "MixMagnitude");
			Property.NativeMethodInfoPtr_ApplyToNPC_Public_Abstract_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667939);
			Property.NativeMethodInfoPtr_ClearFromNPC_Public_Abstract_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667940);
			Property.NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667941);
			Property.NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667942);
			Property.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667943);
			Property.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667944);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000F4614 File Offset: 0x000F2814
		[CallerCount(0)]
		public unsafe virtual void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ApplyToNPC_Public_Abstract_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000F4664 File Offset: 0x000F2864
		[CallerCount(0)]
		public unsafe virtual void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ClearFromNPC_Public_Abstract_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000F46B4 File Offset: 0x000F28B4
		[CallerCount(0)]
		public unsafe virtual void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000F4704 File Offset: 0x000F2904
		[CallerCount(0)]
		public unsafe virtual void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000F4754 File Offset: 0x000F2954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121750, XrefRangeEnd = 121760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000F4788 File Offset: 0x000F2988
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 121770, RefRangeEnd = 121805, XrefRangeStart = 121760, XrefRangeEnd = 121770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00016072 File Offset: 0x00014272
		public Property(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x000F47C4 File Offset: 0x000F29C4
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x0001607B File Offset: 0x0001427B
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000F47EC File Offset: 0x000F29EC
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x0001609A File Offset: 0x0001429A
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000F4814 File Offset: 0x000F2A14
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x000160B9 File Offset: 0x000142B9
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x000F483C File Offset: 0x000F2A3C
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x000160D8 File Offset: 0x000142D8
		public unsafe int Tier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Tier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Tier)) = value;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000F4864 File Offset: 0x000F2A64
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x000160F3 File Offset: 0x000142F3
		public unsafe float Addictiveness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Addictiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Addictiveness)) = value;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x000F488C File Offset: 0x000F2A8C
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x0001610E File Offset: 0x0001430E
		public unsafe Color ProductColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ProductColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ProductColor)) = value;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000F48B4 File Offset: 0x000F2AB4
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x00016129 File Offset: 0x00014329
		public unsafe Color LabelColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LabelColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LabelColor)) = value;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000F48DC File Offset: 0x000F2ADC
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x00016144 File Offset: 0x00014344
		public unsafe bool ImplementedPriorMixingRework
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ImplementedPriorMixingRework);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ImplementedPriorMixingRework)) = value;
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000F4904 File Offset: 0x000F2B04
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x0001615F File Offset: 0x0001435F
		public unsafe int ValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ValueChange)) = value;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x060028D6 RID: 10454 RVA: 0x000F492C File Offset: 0x000F2B2C
		// (set) Token: 0x060028D7 RID: 10455 RVA: 0x0001617A File Offset: 0x0001437A
		public unsafe float ValueMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ValueMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ValueMultiplier)) = value;
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x000F4954 File Offset: 0x000F2B54
		// (set) Token: 0x060028D9 RID: 10457 RVA: 0x00016195 File Offset: 0x00014395
		public unsafe float AddBaseValueMultiple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AddBaseValueMultiple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AddBaseValueMultiple)) = value;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x000F497C File Offset: 0x000F2B7C
		// (set) Token: 0x060028DB RID: 10459 RVA: 0x000161B0 File Offset: 0x000143B0
		public unsafe Vector2 MixDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MixDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MixDirection)) = value;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x000F49A4 File Offset: 0x000F2BA4
		// (set) Token: 0x060028DD RID: 10461 RVA: 0x000161CB File Offset: 0x000143CB
		public unsafe float MixMagnitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MixMagnitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MixMagnitude)) = value;
			}
		}

		// Token: 0x04001B10 RID: 6928
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04001B11 RID: 6929
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04001B12 RID: 6930
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001B13 RID: 6931
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x04001B14 RID: 6932
		private static readonly IntPtr NativeFieldInfoPtr_Addictiveness;

		// Token: 0x04001B15 RID: 6933
		private static readonly IntPtr NativeFieldInfoPtr_ProductColor;

		// Token: 0x04001B16 RID: 6934
		private static readonly IntPtr NativeFieldInfoPtr_LabelColor;

		// Token: 0x04001B17 RID: 6935
		private static readonly IntPtr NativeFieldInfoPtr_ImplementedPriorMixingRework;

		// Token: 0x04001B18 RID: 6936
		private static readonly IntPtr NativeFieldInfoPtr_ValueChange;

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeFieldInfoPtr_ValueMultiplier;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeFieldInfoPtr_AddBaseValueMultiple;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeFieldInfoPtr_MixDirection;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeFieldInfoPtr_MixMagnitude;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Abstract_Virtual_New_Void_NPC_0;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Abstract_Virtual_New_Void_NPC_0;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
