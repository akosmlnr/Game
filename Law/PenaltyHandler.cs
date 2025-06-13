using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003FB RID: 1019
	public static class PenaltyHandler : Il2CppSystem.Object
	{
		// Token: 0x06004DC8 RID: 19912 RVA: 0x00177BBC File Offset: 0x00175DBC
		// Note: this type is marked as 'beforefieldinit'.
		static PenaltyHandler()
		{
			Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PenaltyHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr);
			PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "CONTROLLED_SUBSTANCE_FINE");
			PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "LOW_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "MED_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "HIGH_SEVERITY_DRUG_FINE");
			PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "FAILURE_TO_COMPLY_FINE");
			PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "EVADING_ARREST_FINE");
			PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "VIOLATING_CURFEW_TIME");
			PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "ATTEMPT_TO_SELL_FINE");
			PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "ASSAULT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "DEADLY_ASSAULT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "VANDALISM_FINE");
			PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "THEFT_FINE");
			PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "BRANDISHING_FINE");
			PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, "DISCHARGE_FIREARM_FINE");
			PenaltyHandler.NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PenaltyHandler>.NativeClassPtr, 100672997);
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x00177D18 File Offset: 0x00175F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170124, RefRangeEnd = 170125, XrefRangeStart = 170013, XrefRangeEnd = 170124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> ProcessCrimeList(Dictionary<Crime, int> crimes)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crimes);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PenaltyHandler.NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x00025376 File Offset: 0x00023576
		public PenaltyHandler(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06004DCB RID: 19915 RVA: 0x00177D5C File Offset: 0x00175F5C
		// (set) Token: 0x06004DCC RID: 19916 RVA: 0x0002537F File Offset: 0x0002357F
		public unsafe static float CONTROLLED_SUBSTANCE_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE, (void*)(&value));
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06004DCD RID: 19917 RVA: 0x00177D78 File Offset: 0x00175F78
		// (set) Token: 0x06004DCE RID: 19918 RVA: 0x0002538D File Offset: 0x0002358D
		public unsafe static float LOW_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06004DCF RID: 19919 RVA: 0x00177D94 File Offset: 0x00175F94
		// (set) Token: 0x06004DD0 RID: 19920 RVA: 0x0002539B File Offset: 0x0002359B
		public unsafe static float MED_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x00177DB0 File Offset: 0x00175FB0
		// (set) Token: 0x06004DD2 RID: 19922 RVA: 0x000253A9 File Offset: 0x000235A9
		public unsafe static float HIGH_SEVERITY_DRUG_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE, (void*)(&value));
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x00177DCC File Offset: 0x00175FCC
		// (set) Token: 0x06004DD4 RID: 19924 RVA: 0x000253B7 File Offset: 0x000235B7
		public unsafe static float FAILURE_TO_COMPLY_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE, (void*)(&value));
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06004DD5 RID: 19925 RVA: 0x00177DE8 File Offset: 0x00175FE8
		// (set) Token: 0x06004DD6 RID: 19926 RVA: 0x000253C5 File Offset: 0x000235C5
		public unsafe static float EVADING_ARREST_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_EVADING_ARREST_FINE, (void*)(&value));
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06004DD7 RID: 19927 RVA: 0x00177E04 File Offset: 0x00176004
		// (set) Token: 0x06004DD8 RID: 19928 RVA: 0x000253D3 File Offset: 0x000235D3
		public unsafe static float VIOLATING_CURFEW_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_VIOLATING_CURFEW_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06004DD9 RID: 19929 RVA: 0x00177E20 File Offset: 0x00176020
		// (set) Token: 0x06004DDA RID: 19930 RVA: 0x000253E1 File Offset: 0x000235E1
		public unsafe static float ATTEMPT_TO_SELL_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE, (void*)(&value));
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06004DDB RID: 19931 RVA: 0x00177E3C File Offset: 0x0017603C
		// (set) Token: 0x06004DDC RID: 19932 RVA: 0x000253EF File Offset: 0x000235EF
		public unsafe static float ASSAULT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_ASSAULT_FINE, (void*)(&value));
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06004DDD RID: 19933 RVA: 0x00177E58 File Offset: 0x00176058
		// (set) Token: 0x06004DDE RID: 19934 RVA: 0x000253FD File Offset: 0x000235FD
		public unsafe static float DEADLY_ASSAULT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_DEADLY_ASSAULT_FINE, (void*)(&value));
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06004DDF RID: 19935 RVA: 0x00177E74 File Offset: 0x00176074
		// (set) Token: 0x06004DE0 RID: 19936 RVA: 0x0002540B File Offset: 0x0002360B
		public unsafe static float VANDALISM_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_VANDALISM_FINE, (void*)(&value));
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06004DE1 RID: 19937 RVA: 0x00177E90 File Offset: 0x00176090
		// (set) Token: 0x06004DE2 RID: 19938 RVA: 0x00025419 File Offset: 0x00023619
		public unsafe static float THEFT_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_THEFT_FINE, (void*)(&value));
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x00177EAC File Offset: 0x001760AC
		// (set) Token: 0x06004DE4 RID: 19940 RVA: 0x00025427 File Offset: 0x00023627
		public unsafe static float BRANDISHING_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_BRANDISHING_FINE, (void*)(&value));
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x00177EC8 File Offset: 0x001760C8
		// (set) Token: 0x06004DE6 RID: 19942 RVA: 0x00025435 File Offset: 0x00023635
		public unsafe static float DISCHARGE_FIREARM_FINE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PenaltyHandler.NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE, (void*)(&value));
			}
		}

		// Token: 0x04003466 RID: 13414
		private static readonly System.IntPtr NativeFieldInfoPtr_CONTROLLED_SUBSTANCE_FINE;

		// Token: 0x04003467 RID: 13415
		private static readonly System.IntPtr NativeFieldInfoPtr_LOW_SEVERITY_DRUG_FINE;

		// Token: 0x04003468 RID: 13416
		private static readonly System.IntPtr NativeFieldInfoPtr_MED_SEVERITY_DRUG_FINE;

		// Token: 0x04003469 RID: 13417
		private static readonly System.IntPtr NativeFieldInfoPtr_HIGH_SEVERITY_DRUG_FINE;

		// Token: 0x0400346A RID: 13418
		private static readonly System.IntPtr NativeFieldInfoPtr_FAILURE_TO_COMPLY_FINE;

		// Token: 0x0400346B RID: 13419
		private static readonly System.IntPtr NativeFieldInfoPtr_EVADING_ARREST_FINE;

		// Token: 0x0400346C RID: 13420
		private static readonly System.IntPtr NativeFieldInfoPtr_VIOLATING_CURFEW_TIME;

		// Token: 0x0400346D RID: 13421
		private static readonly System.IntPtr NativeFieldInfoPtr_ATTEMPT_TO_SELL_FINE;

		// Token: 0x0400346E RID: 13422
		private static readonly System.IntPtr NativeFieldInfoPtr_ASSAULT_FINE;

		// Token: 0x0400346F RID: 13423
		private static readonly System.IntPtr NativeFieldInfoPtr_DEADLY_ASSAULT_FINE;

		// Token: 0x04003470 RID: 13424
		private static readonly System.IntPtr NativeFieldInfoPtr_VANDALISM_FINE;

		// Token: 0x04003471 RID: 13425
		private static readonly System.IntPtr NativeFieldInfoPtr_THEFT_FINE;

		// Token: 0x04003472 RID: 13426
		private static readonly System.IntPtr NativeFieldInfoPtr_BRANDISHING_FINE;

		// Token: 0x04003473 RID: 13427
		private static readonly System.IntPtr NativeFieldInfoPtr_DISCHARGE_FIREARM_FINE;

		// Token: 0x04003474 RID: 13428
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCrimeList_Public_Static_List_1_String_Dictionary_2_Crime_Int32_0;
	}
}
