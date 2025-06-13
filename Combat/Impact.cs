using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020004B7 RID: 1207
	[System.Serializable]
	public class Impact : Il2CppSystem.Object
	{
		// Token: 0x06006739 RID: 26425 RVA: 0x001D3BE4 File Offset: 0x001D1DE4
		// Note: this type is marked as 'beforefieldinit'.
		static Impact()
		{
			Il2CppClassPointerStore<Impact>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "Impact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Impact>.NativeClassPtr);
			Impact.NativeFieldInfoPtr_Hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "Hit");
			Impact.NativeFieldInfoPtr_HitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "HitPoint");
			Impact.NativeFieldInfoPtr_ImpactForceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactForceDirection");
			Impact.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactForce");
			Impact.NativeFieldInfoPtr_ImpactDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactDamage");
			Impact.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactType");
			Impact.NativeFieldInfoPtr_ImpactSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactSource");
			Impact.NativeFieldInfoPtr_ImpactID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactID");
			Impact.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676455);
			Impact.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676456);
			Impact.NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676457);
			Impact.NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676458);
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x001D3D04 File Offset: 0x001D1F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210252, RefRangeEnd = 210254, XrefRangeStart = 210246, XrefRangeEnd = 210252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact(RaycastHit hit, Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, Player impactSource, int impactID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref hit;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref hitPoint;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref impactForceDirection;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref impactForce;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref impactDamage;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref impactType;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impactSource);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref impactID;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x001D3DB4 File Offset: 0x001D1FB4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x001D3DF0 File Offset: 0x001D1FF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210254, RefRangeEnd = 210256, XrefRangeStart = 210254, XrefRangeEnd = 210254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLethal(EImpactType impactType)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref impactType;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x001D3E30 File Offset: 0x001D2030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210268, RefRangeEnd = 210270, XrefRangeStart = 210256, XrefRangeEnd = 210268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerImpact(out Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			player = ((intPtr2 == 0) ? null : new Player(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x00030932 File Offset: 0x0002EB32
		public Impact(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x0600673F RID: 26431 RVA: 0x001D3E90 File Offset: 0x001D2090
		// (set) Token: 0x06006740 RID: 26432 RVA: 0x0003093B File Offset: 0x0002EB3B
		public unsafe RaycastHit Hit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_Hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_Hit)) = value;
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06006741 RID: 26433 RVA: 0x001D3EB8 File Offset: 0x001D20B8
		// (set) Token: 0x06006742 RID: 26434 RVA: 0x00030956 File Offset: 0x0002EB56
		public unsafe Vector3 HitPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_HitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_HitPoint)) = value;
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06006743 RID: 26435 RVA: 0x001D3EE0 File Offset: 0x001D20E0
		// (set) Token: 0x06006744 RID: 26436 RVA: 0x00030971 File Offset: 0x0002EB71
		public unsafe Vector3 ImpactForceDirection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForceDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForceDirection)) = value;
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x001D3F08 File Offset: 0x001D2108
		// (set) Token: 0x06006746 RID: 26438 RVA: 0x0003098C File Offset: 0x0002EB8C
		public unsafe float ImpactForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06006747 RID: 26439 RVA: 0x001D3F30 File Offset: 0x001D2130
		// (set) Token: 0x06006748 RID: 26440 RVA: 0x000309A7 File Offset: 0x0002EBA7
		public unsafe float ImpactDamage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactDamage)) = value;
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x001D3F58 File Offset: 0x001D2158
		// (set) Token: 0x0600674A RID: 26442 RVA: 0x000309C2 File Offset: 0x0002EBC2
		public unsafe EImpactType ImpactType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600674B RID: 26443 RVA: 0x001D3F80 File Offset: 0x001D2180
		// (set) Token: 0x0600674C RID: 26444 RVA: 0x000309DD File Offset: 0x0002EBDD
		public unsafe NetworkObject ImpactSource
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactSource);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600674D RID: 26445 RVA: 0x001D3FB0 File Offset: 0x001D21B0
		// (set) Token: 0x0600674E RID: 26446 RVA: 0x000309FC File Offset: 0x0002EBFC
		public unsafe int ImpactID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactID)) = value;
			}
		}

		// Token: 0x04004679 RID: 18041
		private static readonly System.IntPtr NativeFieldInfoPtr_Hit;

		// Token: 0x0400467A RID: 18042
		private static readonly System.IntPtr NativeFieldInfoPtr_HitPoint;

		// Token: 0x0400467B RID: 18043
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactForceDirection;

		// Token: 0x0400467C RID: 18044
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x0400467D RID: 18045
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactDamage;

		// Token: 0x0400467E RID: 18046
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x0400467F RID: 18047
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactSource;

		// Token: 0x04004680 RID: 18048
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactID;

		// Token: 0x04004681 RID: 18049
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0;

		// Token: 0x04004682 RID: 18050
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004683 RID: 18051
		private static readonly System.IntPtr NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0;

		// Token: 0x04004684 RID: 18052
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0;
	}
}
