using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000431 RID: 1073
	[System.Serializable]
	public class CustomerData : ScriptableObject
	{
		// Token: 0x06005BFC RID: 23548 RVA: 0x001AD6A8 File Offset: 0x001AB8A8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerData()
		{
			Il2CppClassPointerStore<CustomerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerData>.NativeClassPtr);
			CustomerData.NativeFieldInfoPtr_DefaultAffinityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "DefaultAffinityData");
			CustomerData.NativeFieldInfoPtr_PreferredProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PreferredProperties");
			CustomerData.NativeFieldInfoPtr_MinWeeklySpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinWeeklySpend");
			CustomerData.NativeFieldInfoPtr_MaxWeeklySpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxWeeklySpend");
			CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinOrdersPerWeek");
			CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxOrdersPerWeek");
			CustomerData.NativeFieldInfoPtr_OrderTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OrderTime");
			CustomerData.NativeFieldInfoPtr_PreferredOrderDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PreferredOrderDay");
			CustomerData.NativeFieldInfoPtr_Standards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "Standards");
			CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CanBeDirectlyApproached");
			CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "GuaranteeFirstSampleSuccess");
			CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinMutualRelationRequirement");
			CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxMutualRelationRequirement");
			CustomerData.NativeFieldInfoPtr_CallPoliceChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CallPoliceChance");
			CustomerData.NativeFieldInfoPtr_DependenceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "DependenceMultiplier");
			CustomerData.NativeFieldInfoPtr_BaseAddiction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "BaseAddiction");
			CustomerData.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "onChanged");
			CustomerData.NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100675098);
			CustomerData.NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100675099);
			CustomerData.NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100675100);
			CustomerData.NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100675101);
			CustomerData.NativeMethodInfoPtr_RandomizeProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100675102);
			CustomerData.NativeMethodInfoPtr_RandomizeTiming_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100675103);
			CustomerData.NativeMethodInfoPtr_ClearInvalid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100675104);
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100675105);
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x001AD8CC File Offset: 0x001ABACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194777, RefRangeEnd = 194779, XrefRangeStart = 194777, XrefRangeEnd = 194777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetQualityScalar(EQuality quality)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quality;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x001AD90C File Offset: 0x001ABB0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194792, RefRangeEnd = 194795, XrefRangeStart = 194779, XrefRangeEnd = 194792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EDay> GetOrderDays(float dependence, float normalizedRelationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref dependence;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref normalizedRelationship;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EDay>>(intPtr2) : null;
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x001AD968 File Offset: 0x001ABB68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194802, RefRangeEnd = 194805, XrefRangeStart = 194795, XrefRangeEnd = 194802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref normalizedRelationship;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x001AD9B4 File Offset: 0x001ABBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194805, XrefRangeEnd = 194853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeAffinities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x001AD9E8 File Offset: 0x001ABBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194853, XrefRangeEnd = 194899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x001ADA1C File Offset: 0x001ABC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194899, XrefRangeEnd = 194903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeTiming_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x001ADA50 File Offset: 0x001ABC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194903, XrefRangeEnd = 194908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_ClearInvalid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x001ADA84 File Offset: 0x001ABC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194908, XrefRangeEnd = 194916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x0002B3C7 File Offset: 0x000295C7
		public CustomerData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06005C06 RID: 23558 RVA: 0x001ADAC0 File Offset: 0x001ABCC0
		// (set) Token: 0x06005C07 RID: 23559 RVA: 0x0002B3D0 File Offset: 0x000295D0
		public unsafe CustomerAffinityData DefaultAffinityData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DefaultAffinityData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAffinityData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DefaultAffinityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06005C08 RID: 23560 RVA: 0x001ADAF0 File Offset: 0x001ABCF0
		// (set) Token: 0x06005C09 RID: 23561 RVA: 0x0002B3EF File Offset: 0x000295EF
		public unsafe List<Property> PreferredProperties
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredProperties);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x001ADB20 File Offset: 0x001ABD20
		// (set) Token: 0x06005C0B RID: 23563 RVA: 0x0002B40E File Offset: 0x0002960E
		public unsafe float MinWeeklySpend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinWeeklySpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinWeeklySpend)) = value;
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06005C0C RID: 23564 RVA: 0x001ADB48 File Offset: 0x001ABD48
		// (set) Token: 0x06005C0D RID: 23565 RVA: 0x0002B429 File Offset: 0x00029629
		public unsafe float MaxWeeklySpend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxWeeklySpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxWeeklySpend)) = value;
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x001ADB70 File Offset: 0x001ABD70
		// (set) Token: 0x06005C0F RID: 23567 RVA: 0x0002B444 File Offset: 0x00029644
		public unsafe int MinOrdersPerWeek
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek)) = value;
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x001ADB98 File Offset: 0x001ABD98
		// (set) Token: 0x06005C11 RID: 23569 RVA: 0x0002B45F File Offset: 0x0002965F
		public unsafe int MaxOrdersPerWeek
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek)) = value;
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06005C12 RID: 23570 RVA: 0x001ADBC0 File Offset: 0x001ABDC0
		// (set) Token: 0x06005C13 RID: 23571 RVA: 0x0002B47A File Offset: 0x0002967A
		public unsafe int OrderTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OrderTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OrderTime)) = value;
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06005C14 RID: 23572 RVA: 0x001ADBE8 File Offset: 0x001ABDE8
		// (set) Token: 0x06005C15 RID: 23573 RVA: 0x0002B495 File Offset: 0x00029695
		public unsafe EDay PreferredOrderDay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredOrderDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredOrderDay)) = value;
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06005C16 RID: 23574 RVA: 0x001ADC10 File Offset: 0x001ABE10
		// (set) Token: 0x06005C17 RID: 23575 RVA: 0x0002B4B0 File Offset: 0x000296B0
		public unsafe ECustomerStandard Standards
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Standards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Standards)) = value;
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x001ADC38 File Offset: 0x001ABE38
		// (set) Token: 0x06005C19 RID: 23577 RVA: 0x0002B4CB File Offset: 0x000296CB
		public unsafe bool CanBeDirectlyApproached
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached)) = value;
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06005C1A RID: 23578 RVA: 0x001ADC60 File Offset: 0x001ABE60
		// (set) Token: 0x06005C1B RID: 23579 RVA: 0x0002B4E6 File Offset: 0x000296E6
		public unsafe bool GuaranteeFirstSampleSuccess
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess)) = value;
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06005C1C RID: 23580 RVA: 0x001ADC88 File Offset: 0x001ABE88
		// (set) Token: 0x06005C1D RID: 23581 RVA: 0x0002B501 File Offset: 0x00029701
		public unsafe float MinMutualRelationRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement)) = value;
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06005C1E RID: 23582 RVA: 0x001ADCB0 File Offset: 0x001ABEB0
		// (set) Token: 0x06005C1F RID: 23583 RVA: 0x0002B51C File Offset: 0x0002971C
		public unsafe float MaxMutualRelationRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement)) = value;
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x001ADCD8 File Offset: 0x001ABED8
		// (set) Token: 0x06005C21 RID: 23585 RVA: 0x0002B537 File Offset: 0x00029737
		public unsafe float CallPoliceChance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CallPoliceChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CallPoliceChance)) = value;
			}
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06005C22 RID: 23586 RVA: 0x001ADD00 File Offset: 0x001ABF00
		// (set) Token: 0x06005C23 RID: 23587 RVA: 0x0002B552 File Offset: 0x00029752
		public unsafe float DependenceMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DependenceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DependenceMultiplier)) = value;
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06005C24 RID: 23588 RVA: 0x001ADD28 File Offset: 0x001ABF28
		// (set) Token: 0x06005C25 RID: 23589 RVA: 0x0002B56D File Offset: 0x0002976D
		public unsafe float BaseAddiction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_BaseAddiction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_BaseAddiction)) = value;
			}
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06005C26 RID: 23590 RVA: 0x001ADD50 File Offset: 0x001ABF50
		// (set) Token: 0x06005C27 RID: 23591 RVA: 0x0002B588 File Offset: 0x00029788
		public unsafe Il2CppSystem.Action onChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_onChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003ECE RID: 16078
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultAffinityData;

		// Token: 0x04003ECF RID: 16079
		private static readonly System.IntPtr NativeFieldInfoPtr_PreferredProperties;

		// Token: 0x04003ED0 RID: 16080
		private static readonly System.IntPtr NativeFieldInfoPtr_MinWeeklySpend;

		// Token: 0x04003ED1 RID: 16081
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxWeeklySpend;

		// Token: 0x04003ED2 RID: 16082
		private static readonly System.IntPtr NativeFieldInfoPtr_MinOrdersPerWeek;

		// Token: 0x04003ED3 RID: 16083
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxOrdersPerWeek;

		// Token: 0x04003ED4 RID: 16084
		private static readonly System.IntPtr NativeFieldInfoPtr_OrderTime;

		// Token: 0x04003ED5 RID: 16085
		private static readonly System.IntPtr NativeFieldInfoPtr_PreferredOrderDay;

		// Token: 0x04003ED6 RID: 16086
		private static readonly System.IntPtr NativeFieldInfoPtr_Standards;

		// Token: 0x04003ED7 RID: 16087
		private static readonly System.IntPtr NativeFieldInfoPtr_CanBeDirectlyApproached;

		// Token: 0x04003ED8 RID: 16088
		private static readonly System.IntPtr NativeFieldInfoPtr_GuaranteeFirstSampleSuccess;

		// Token: 0x04003ED9 RID: 16089
		private static readonly System.IntPtr NativeFieldInfoPtr_MinMutualRelationRequirement;

		// Token: 0x04003EDA RID: 16090
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxMutualRelationRequirement;

		// Token: 0x04003EDB RID: 16091
		private static readonly System.IntPtr NativeFieldInfoPtr_CallPoliceChance;

		// Token: 0x04003EDC RID: 16092
		private static readonly System.IntPtr NativeFieldInfoPtr_DependenceMultiplier;

		// Token: 0x04003EDD RID: 16093
		private static readonly System.IntPtr NativeFieldInfoPtr_BaseAddiction;

		// Token: 0x04003EDE RID: 16094
		private static readonly System.IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04003EDF RID: 16095
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0;

		// Token: 0x04003EE0 RID: 16096
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0;

		// Token: 0x04003EE1 RID: 16097
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0;

		// Token: 0x04003EE2 RID: 16098
		private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0;

		// Token: 0x04003EE3 RID: 16099
		private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeProperties_Public_Void_0;

		// Token: 0x04003EE4 RID: 16100
		private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeTiming_Public_Void_0;

		// Token: 0x04003EE5 RID: 16101
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearInvalid_Public_Void_0;

		// Token: 0x04003EE6 RID: 16102
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
