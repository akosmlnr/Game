using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000798 RID: 1944
	public class UtilityPole : MonoBehaviour
	{
		// Token: 0x0600B856 RID: 47190 RVA: 0x002E123C File Offset: 0x002DF43C
		// Note: this type is marked as 'beforefieldinit'.
		static UtilityPole()
		{
			Il2CppClassPointerStore<UtilityPole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "UtilityPole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr);
			UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "CABLE_CULL_DISTANCE");
			UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "CABLE_CULL_DISTANCE_SQR");
			UtilityPole.NativeFieldInfoPtr_previousPole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "previousPole");
			UtilityPole.NativeFieldInfoPtr_nextPole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "nextPole");
			UtilityPole.NativeFieldInfoPtr_Connection1Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Connection1Enabled");
			UtilityPole.NativeFieldInfoPtr_Connection2Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Connection2Enabled");
			UtilityPole.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "LengthFactor");
			UtilityPole.NativeFieldInfoPtr_cable1Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable1Connection");
			UtilityPole.NativeFieldInfoPtr_cable2Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable2Connection");
			UtilityPole.NativeFieldInfoPtr_cable1Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable1Segments");
			UtilityPole.NativeFieldInfoPtr_cable2Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable2Segments");
			UtilityPole.NativeFieldInfoPtr_Cable1Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Cable1Container");
			UtilityPole.NativeFieldInfoPtr_Cable2Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Cable2Container");
			UtilityPole.NativeFieldInfoPtr_cableStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableStart");
			UtilityPole.NativeFieldInfoPtr_cableEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableEnd");
			UtilityPole.NativeFieldInfoPtr_cableMid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableMid");
			UtilityPole.NativeMethodInfoPtr_Awake_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100686152);
			UtilityPole.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100686153);
			UtilityPole.NativeMethodInfoPtr_UpdateCulling_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100686154);
			UtilityPole.NativeMethodInfoPtr_Orient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100686155);
			UtilityPole.NativeMethodInfoPtr_DrawLines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100686156);
			UtilityPole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100686157);
			UtilityPole.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100686158);
		}

		// Token: 0x0600B857 RID: 47191 RVA: 0x002E1438 File Offset: 0x002DF638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315459, XrefRangeEnd = 315467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Awake_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B858 RID: 47192 RVA: 0x002E146C File Offset: 0x002DF66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315467, XrefRangeEnd = 315491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B859 RID: 47193 RVA: 0x002E14A0 File Offset: 0x002DF6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315491, XrefRangeEnd = 315519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_UpdateCulling_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B85A RID: 47194 RVA: 0x002E14D4 File Offset: 0x002DF6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315519, XrefRangeEnd = 315568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Orient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Orient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B85B RID: 47195 RVA: 0x002E1508 File Offset: 0x002DF708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315568, XrefRangeEnd = 315636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_DrawLines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B85C RID: 47196 RVA: 0x002E153C File Offset: 0x002DF73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315636, XrefRangeEnd = 315655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UtilityPole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B85D RID: 47197 RVA: 0x002E1578 File Offset: 0x002DF778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315686, RefRangeEnd = 315687, XrefRangeStart = 315655, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B85E RID: 47198 RVA: 0x0005A00F File Offset: 0x0005820F
		public UtilityPole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600B85F RID: 47199 RVA: 0x002E15AC File Offset: 0x002DF7AC
		// (set) Token: 0x0600B860 RID: 47200 RVA: 0x0005A018 File Offset: 0x00058218
		public unsafe static float CABLE_CULL_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600B861 RID: 47201 RVA: 0x002E15C8 File Offset: 0x002DF7C8
		// (set) Token: 0x0600B862 RID: 47202 RVA: 0x0005A026 File Offset: 0x00058226
		public unsafe static float CABLE_CULL_DISTANCE_SQR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR, (void*)(&value));
			}
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600B863 RID: 47203 RVA: 0x002E15E4 File Offset: 0x002DF7E4
		// (set) Token: 0x0600B864 RID: 47204 RVA: 0x0005A034 File Offset: 0x00058234
		public unsafe UtilityPole previousPole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_previousPole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UtilityPole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_previousPole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600B865 RID: 47205 RVA: 0x002E1614 File Offset: 0x002DF814
		// (set) Token: 0x0600B866 RID: 47206 RVA: 0x0005A053 File Offset: 0x00058253
		public unsafe UtilityPole nextPole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_nextPole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UtilityPole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_nextPole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600B867 RID: 47207 RVA: 0x002E1644 File Offset: 0x002DF844
		// (set) Token: 0x0600B868 RID: 47208 RVA: 0x0005A072 File Offset: 0x00058272
		public unsafe bool Connection1Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection1Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection1Enabled)) = value;
			}
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600B869 RID: 47209 RVA: 0x002E166C File Offset: 0x002DF86C
		// (set) Token: 0x0600B86A RID: 47210 RVA: 0x0005A08D File Offset: 0x0005828D
		public unsafe bool Connection2Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection2Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection2Enabled)) = value;
			}
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600B86B RID: 47211 RVA: 0x002E1694 File Offset: 0x002DF894
		// (set) Token: 0x0600B86C RID: 47212 RVA: 0x0005A0A8 File Offset: 0x000582A8
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600B86D RID: 47213 RVA: 0x002E16BC File Offset: 0x002DF8BC
		// (set) Token: 0x0600B86E RID: 47214 RVA: 0x0005A0C3 File Offset: 0x000582C3
		public unsafe Transform cable1Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600B86F RID: 47215 RVA: 0x002E16EC File Offset: 0x002DF8EC
		// (set) Token: 0x0600B870 RID: 47216 RVA: 0x0005A0E2 File Offset: 0x000582E2
		public unsafe Transform cable2Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600B871 RID: 47217 RVA: 0x002E171C File Offset: 0x002DF91C
		// (set) Token: 0x0600B872 RID: 47218 RVA: 0x0005A101 File Offset: 0x00058301
		public unsafe List<Transform> cable1Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600B873 RID: 47219 RVA: 0x002E174C File Offset: 0x002DF94C
		// (set) Token: 0x0600B874 RID: 47220 RVA: 0x0005A120 File Offset: 0x00058320
		public unsafe List<Transform> cable2Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600B875 RID: 47221 RVA: 0x002E177C File Offset: 0x002DF97C
		// (set) Token: 0x0600B876 RID: 47222 RVA: 0x0005A13F File Offset: 0x0005833F
		public unsafe Transform Cable1Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable1Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable1Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600B877 RID: 47223 RVA: 0x002E17AC File Offset: 0x002DF9AC
		// (set) Token: 0x0600B878 RID: 47224 RVA: 0x0005A15E File Offset: 0x0005835E
		public unsafe Transform Cable2Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable2Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable2Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600B879 RID: 47225 RVA: 0x002E17DC File Offset: 0x002DF9DC
		// (set) Token: 0x0600B87A RID: 47226 RVA: 0x0005A17D File Offset: 0x0005837D
		public unsafe Vector3 cableStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableStart)) = value;
			}
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600B87B RID: 47227 RVA: 0x002E1804 File Offset: 0x002DFA04
		// (set) Token: 0x0600B87C RID: 47228 RVA: 0x0005A198 File Offset: 0x00058398
		public unsafe Vector3 cableEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableEnd)) = value;
			}
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600B87D RID: 47229 RVA: 0x002E182C File Offset: 0x002DFA2C
		// (set) Token: 0x0600B87E RID: 47230 RVA: 0x0005A1B3 File Offset: 0x000583B3
		public unsafe Vector3 cableMid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableMid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableMid)) = value;
			}
		}

		// Token: 0x04007C6C RID: 31852
		private static readonly IntPtr NativeFieldInfoPtr_CABLE_CULL_DISTANCE;

		// Token: 0x04007C6D RID: 31853
		private static readonly IntPtr NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR;

		// Token: 0x04007C6E RID: 31854
		private static readonly IntPtr NativeFieldInfoPtr_previousPole;

		// Token: 0x04007C6F RID: 31855
		private static readonly IntPtr NativeFieldInfoPtr_nextPole;

		// Token: 0x04007C70 RID: 31856
		private static readonly IntPtr NativeFieldInfoPtr_Connection1Enabled;

		// Token: 0x04007C71 RID: 31857
		private static readonly IntPtr NativeFieldInfoPtr_Connection2Enabled;

		// Token: 0x04007C72 RID: 31858
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x04007C73 RID: 31859
		private static readonly IntPtr NativeFieldInfoPtr_cable1Connection;

		// Token: 0x04007C74 RID: 31860
		private static readonly IntPtr NativeFieldInfoPtr_cable2Connection;

		// Token: 0x04007C75 RID: 31861
		private static readonly IntPtr NativeFieldInfoPtr_cable1Segments;

		// Token: 0x04007C76 RID: 31862
		private static readonly IntPtr NativeFieldInfoPtr_cable2Segments;

		// Token: 0x04007C77 RID: 31863
		private static readonly IntPtr NativeFieldInfoPtr_Cable1Container;

		// Token: 0x04007C78 RID: 31864
		private static readonly IntPtr NativeFieldInfoPtr_Cable2Container;

		// Token: 0x04007C79 RID: 31865
		private static readonly IntPtr NativeFieldInfoPtr_cableStart;

		// Token: 0x04007C7A RID: 31866
		private static readonly IntPtr NativeFieldInfoPtr_cableEnd;

		// Token: 0x04007C7B RID: 31867
		private static readonly IntPtr NativeFieldInfoPtr_cableMid;

		// Token: 0x04007C7C RID: 31868
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_1;

		// Token: 0x04007C7D RID: 31869
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04007C7E RID: 31870
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_1;

		// Token: 0x04007C7F RID: 31871
		private static readonly IntPtr NativeMethodInfoPtr_Orient_Public_Void_0;

		// Token: 0x04007C80 RID: 31872
		private static readonly IntPtr NativeMethodInfoPtr_DrawLines_Public_Void_0;

		// Token: 0x04007C81 RID: 31873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007C82 RID: 31874
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
