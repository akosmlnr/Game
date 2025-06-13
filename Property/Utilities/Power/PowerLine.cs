using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x0200053A RID: 1338
	public class PowerLine : Constructable
	{
		// Token: 0x06007614 RID: 30228 RVA: 0x00204FAC File Offset: 0x002031AC
		// Note: this type is marked as 'beforefieldinit'.
		static PowerLine()
		{
			Il2CppClassPointerStore<PowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerLine>.NativeClassPtr);
			PowerLine.NativeFieldInfoPtr_powerLine_MinSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "powerLine_MinSegments");
			PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "powerLine_MaxSegments");
			PowerLine.NativeFieldInfoPtr_maxLineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "maxLineLength");
			PowerLine.NativeFieldInfoPtr_updateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "updateThreshold");
			PowerLine.NativeFieldInfoPtr_nodeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeA");
			PowerLine.NativeFieldInfoPtr_nodeB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeB");
			PowerLine.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "LengthFactor");
			PowerLine.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "segments");
			PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeA_LastUpdatePos");
			PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "nodeB_LastUpdatePos");
			PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted");
			PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted");
			PowerLine.NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678241);
			PowerLine.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678242);
			PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678243);
			PowerLine.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678244);
			PowerLine.NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678245);
			PowerLine.NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678246);
			PowerLine.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678247);
			PowerLine.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678248);
			PowerLine.NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678249);
			PowerLine.NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678250);
			PowerLine.NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678251);
			PowerLine.NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678252);
			PowerLine.NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678253);
			PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678254);
			PowerLine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678256);
			PowerLine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678257);
			PowerLine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678258);
			PowerLine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerLine>.NativeClassPtr, 100678259);
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x00205234 File Offset: 0x00203434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230721, RefRangeEnd = 230722, XrefRangeStart = 230682, XrefRangeEnd = 230721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializePowerLine(PowerNode a, PowerNode b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00205288 File Offset: 0x00203488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230722, XrefRangeEnd = 230744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x002052D4 File Offset: 0x002034D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230744, XrefRangeEnd = 230786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00205310 File Offset: 0x00203510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230835, RefRangeEnd = 230838, XrefRangeStart = 230786, XrefRangeEnd = 230835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00205344 File Offset: 0x00203544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230858, RefRangeEnd = 230859, XrefRangeStart = 230838, XrefRangeEnd = 230858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshBoundingBox()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00205378 File Offset: 0x00203578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230866, RefRangeEnd = 230868, XrefRangeStart = 230859, XrefRangeEnd = 230866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode GetOtherNode(PowerNode firstNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstNode);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x002053C8 File Offset: 0x002035C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230875, RefRangeEnd = 230877, XrefRangeStart = 230868, XrefRangeEnd = 230875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00205408 File Offset: 0x00203608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230877, XrefRangeEnd = 230881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetCosmeticCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00205450 File Offset: 0x00203650
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 230917, RefRangeEnd = 230924, XrefRangeStart = 230881, XrefRangeEnd = 230917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanNodesBeConnected(PowerNode nodeA, PowerNode nodeB)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodeB);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x002054A4 File Offset: 0x002036A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230934, RefRangeEnd = 230936, XrefRangeStart = 230924, XrefRangeEnd = 230934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSegmentCount(Vector3 startPoint, Vector3 endPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x002054F0 File Offset: 0x002036F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 230943, RefRangeEnd = 230947, XrefRangeStart = 230936, XrefRangeEnd = 230943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPowerLine(Vector3 startPoint, Vector3 endPoint, List<Transform> segments, float lengthFactor)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(segments);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthFactor;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00205550 File Offset: 0x00203750
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230985, RefRangeEnd = 230988, XrefRangeStart = 230947, XrefRangeEnd = 230985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PositionSegments(List<Vector3> points, List<Transform> segments)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(segments);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x00205598 File Offset: 0x00203798
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231061, RefRangeEnd = 231064, XrefRangeStart = 230988, XrefRangeEnd = 231061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> GetCatenaryPoints(Vector3 startPoint, Vector3 endPoint, int pointCount, float l)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x00205604 File Offset: 0x00203804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231064, XrefRangeEnd = 231076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerLine>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00205640 File Offset: 0x00203840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231076, XrefRangeEnd = 231077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x0020567C File Offset: 0x0020387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231077, XrefRangeEnd = 231078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x002056B8 File Offset: 0x002038B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x002056F4 File Offset: 0x002038F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231078, XrefRangeEnd = 231079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PowerLine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x00037D99 File Offset: 0x00035F99
		public PowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x06007628 RID: 30248 RVA: 0x00205730 File Offset: 0x00203930
		// (set) Token: 0x06007629 RID: 30249 RVA: 0x00037DA2 File Offset: 0x00035FA2
		public unsafe static int powerLine_MinSegments
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_powerLine_MinSegments, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_powerLine_MinSegments, (void*)(&value));
			}
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x0600762A RID: 30250 RVA: 0x0020574C File Offset: 0x0020394C
		// (set) Token: 0x0600762B RID: 30251 RVA: 0x00037DB0 File Offset: 0x00035FB0
		public unsafe static int powerLine_MaxSegments
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_powerLine_MaxSegments, (void*)(&value));
			}
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x0600762C RID: 30252 RVA: 0x00205768 File Offset: 0x00203968
		// (set) Token: 0x0600762D RID: 30253 RVA: 0x00037DBE File Offset: 0x00035FBE
		public unsafe static float maxLineLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_maxLineLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_maxLineLength, (void*)(&value));
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x0600762E RID: 30254 RVA: 0x00205784 File Offset: 0x00203984
		// (set) Token: 0x0600762F RID: 30255 RVA: 0x00037DCC File Offset: 0x00035FCC
		public unsafe static float updateThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PowerLine.NativeFieldInfoPtr_updateThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PowerLine.NativeFieldInfoPtr_updateThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x002057A0 File Offset: 0x002039A0
		// (set) Token: 0x06007631 RID: 30257 RVA: 0x00037DDA File Offset: 0x00035FDA
		public unsafe PowerNode nodeA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x06007632 RID: 30258 RVA: 0x002057D0 File Offset: 0x002039D0
		// (set) Token: 0x06007633 RID: 30259 RVA: 0x00037DF9 File Offset: 0x00035FF9
		public unsafe PowerNode nodeB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x06007634 RID: 30260 RVA: 0x00205800 File Offset: 0x00203A00
		// (set) Token: 0x06007635 RID: 30261 RVA: 0x00037E18 File Offset: 0x00036018
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x00205828 File Offset: 0x00203A28
		// (set) Token: 0x06007637 RID: 30263 RVA: 0x00037E33 File Offset: 0x00036033
		public unsafe List<Transform> segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x00205858 File Offset: 0x00203A58
		// (set) Token: 0x06007639 RID: 30265 RVA: 0x00037E52 File Offset: 0x00036052
		public unsafe Vector3 nodeA_LastUpdatePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeA_LastUpdatePos)) = value;
			}
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x0600763A RID: 30266 RVA: 0x00205880 File Offset: 0x00203A80
		// (set) Token: 0x0600763B RID: 30267 RVA: 0x00037E6D File Offset: 0x0003606D
		public unsafe Vector3 nodeB_LastUpdatePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_nodeB_LastUpdatePos)) = value;
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x0600763C RID: 30268 RVA: 0x002058A8 File Offset: 0x00203AA8
		// (set) Token: 0x0600763D RID: 30269 RVA: 0x00037E88 File Offset: 0x00036088
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x0600763E RID: 30270 RVA: 0x002058D0 File Offset: 0x00203AD0
		// (set) Token: 0x0600763F RID: 30271 RVA: 0x00037EA3 File Offset: 0x000360A3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerLine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040050A5 RID: 20645
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_MinSegments;

		// Token: 0x040050A6 RID: 20646
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_MaxSegments;

		// Token: 0x040050A7 RID: 20647
		private static readonly IntPtr NativeFieldInfoPtr_maxLineLength;

		// Token: 0x040050A8 RID: 20648
		private static readonly IntPtr NativeFieldInfoPtr_updateThreshold;

		// Token: 0x040050A9 RID: 20649
		private static readonly IntPtr NativeFieldInfoPtr_nodeA;

		// Token: 0x040050AA RID: 20650
		private static readonly IntPtr NativeFieldInfoPtr_nodeB;

		// Token: 0x040050AB RID: 20651
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x040050AC RID: 20652
		private static readonly IntPtr NativeFieldInfoPtr_segments;

		// Token: 0x040050AD RID: 20653
		private static readonly IntPtr NativeFieldInfoPtr_nodeA_LastUpdatePos;

		// Token: 0x040050AE RID: 20654
		private static readonly IntPtr NativeFieldInfoPtr_nodeB_LastUpdatePos;

		// Token: 0x040050AF RID: 20655
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040050B0 RID: 20656
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040050B1 RID: 20657
		private static readonly IntPtr NativeMethodInfoPtr_InitializePowerLine_Public_Void_PowerNode_PowerNode_0;

		// Token: 0x040050B2 RID: 20658
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0;

		// Token: 0x040050B3 RID: 20659
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040050B4 RID: 20660
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Private_Void_0;

		// Token: 0x040050B5 RID: 20661
		private static readonly IntPtr NativeMethodInfoPtr_RefreshBoundingBox_Private_Void_0;

		// Token: 0x040050B6 RID: 20662
		private static readonly IntPtr NativeMethodInfoPtr_GetOtherNode_Public_PowerNode_PowerNode_0;

		// Token: 0x040050B7 RID: 20663
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040050B8 RID: 20664
		private static readonly IntPtr NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_Vector3_0;

		// Token: 0x040050B9 RID: 20665
		private static readonly IntPtr NativeMethodInfoPtr_CanNodesBeConnected_Public_Static_Boolean_PowerNode_PowerNode_0;

		// Token: 0x040050BA RID: 20666
		private static readonly IntPtr NativeMethodInfoPtr_GetSegmentCount_Public_Static_Int32_Vector3_Vector3_0;

		// Token: 0x040050BB RID: 20667
		private static readonly IntPtr NativeMethodInfoPtr_DrawPowerLine_Public_Static_Void_Vector3_Vector3_List_1_Transform_Single_0;

		// Token: 0x040050BC RID: 20668
		private static readonly IntPtr NativeMethodInfoPtr_PositionSegments_Private_Static_Void_List_1_Vector3_List_1_Transform_0;

		// Token: 0x040050BD RID: 20669
		private static readonly IntPtr NativeMethodInfoPtr_GetCatenaryPoints_Private_Static_List_1_Vector3_Vector3_Vector3_Int32_Single_0;

		// Token: 0x040050BE RID: 20670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040050BF RID: 20671
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040050C0 RID: 20672
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040050C1 RID: 20673
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040050C2 RID: 20674
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
