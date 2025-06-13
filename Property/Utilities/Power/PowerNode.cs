using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x0200053C RID: 1340
	public class PowerNode : MonoBehaviour
	{
		// Token: 0x06007651 RID: 30289 RVA: 0x00205C78 File Offset: 0x00203E78
		// Note: this type is marked as 'beforefieldinit'.
		static PowerNode()
		{
			Il2CppClassPointerStore<PowerNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerNode>.NativeClassPtr);
			PowerNode.NativeFieldInfoPtr_poweredNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "poweredNode");
			PowerNode.NativeFieldInfoPtr_consumptionNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "consumptionNode");
			PowerNode.NativeFieldInfoPtr_isConnectedToPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "isConnectedToPower");
			PowerNode.NativeFieldInfoPtr_connectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "connectionPoint");
			PowerNode.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, "connections");
			PowerNode.NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100678268);
			PowerNode.NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100678269);
			PowerNode.NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100678270);
			PowerNode.NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100678271);
			PowerNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNode>.NativeClassPtr, 100678272);
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x06007652 RID: 30290 RVA: 0x00205D70 File Offset: 0x00203F70
		public unsafe Transform pConnectionPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00205DB0 File Offset: 0x00203FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231176, XrefRangeEnd = 231192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsConnectedTo(PowerNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00205E00 File Offset: 0x00204000
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 231224, RefRangeEnd = 231227, XrefRangeStart = 231192, XrefRangeEnd = 231224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculatePowerNetwork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x00205E34 File Offset: 0x00204034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 231260, RefRangeEnd = 231262, XrefRangeStart = 231227, XrefRangeEnd = 231260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PowerNode> GetConnectedNodes(List<PowerNode> exclusions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exclusions);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PowerNode>>(intPtr2) : null;
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x00205E84 File Offset: 0x00204084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231262, XrefRangeEnd = 231270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerNode>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x00037F2E File Offset: 0x0003612E
		public PowerNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x06007658 RID: 30296 RVA: 0x00205EC0 File Offset: 0x002040C0
		// (set) Token: 0x06007659 RID: 30297 RVA: 0x00037F37 File Offset: 0x00036137
		public unsafe bool poweredNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_poweredNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_poweredNode)) = value;
			}
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x0600765A RID: 30298 RVA: 0x00205EE8 File Offset: 0x002040E8
		// (set) Token: 0x0600765B RID: 30299 RVA: 0x00037F52 File Offset: 0x00036152
		public unsafe bool consumptionNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_consumptionNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_consumptionNode)) = value;
			}
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x0600765C RID: 30300 RVA: 0x00205F10 File Offset: 0x00204110
		// (set) Token: 0x0600765D RID: 30301 RVA: 0x00037F6D File Offset: 0x0003616D
		public unsafe bool isConnectedToPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_isConnectedToPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_isConnectedToPower)) = value;
			}
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x0600765E RID: 30302 RVA: 0x00205F38 File Offset: 0x00204138
		// (set) Token: 0x0600765F RID: 30303 RVA: 0x00037F88 File Offset: 0x00036188
		public unsafe Transform connectionPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connectionPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connectionPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x06007660 RID: 30304 RVA: 0x00205F68 File Offset: 0x00204168
		// (set) Token: 0x06007661 RID: 30305 RVA: 0x00037FA7 File Offset: 0x000361A7
		public unsafe List<PowerLine> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PowerLine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNode.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050CE RID: 20686
		private static readonly IntPtr NativeFieldInfoPtr_poweredNode;

		// Token: 0x040050CF RID: 20687
		private static readonly IntPtr NativeFieldInfoPtr_consumptionNode;

		// Token: 0x040050D0 RID: 20688
		private static readonly IntPtr NativeFieldInfoPtr_isConnectedToPower;

		// Token: 0x040050D1 RID: 20689
		private static readonly IntPtr NativeFieldInfoPtr_connectionPoint;

		// Token: 0x040050D2 RID: 20690
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x040050D3 RID: 20691
		private static readonly IntPtr NativeMethodInfoPtr_get_pConnectionPoint_Public_get_Transform_0;

		// Token: 0x040050D4 RID: 20692
		private static readonly IntPtr NativeMethodInfoPtr_IsConnectedTo_Public_Boolean_PowerNode_0;

		// Token: 0x040050D5 RID: 20693
		private static readonly IntPtr NativeMethodInfoPtr_RecalculatePowerNetwork_Public_Void_0;

		// Token: 0x040050D6 RID: 20694
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedNodes_Public_List_1_PowerNode_List_1_PowerNode_0;

		// Token: 0x040050D7 RID: 20695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
