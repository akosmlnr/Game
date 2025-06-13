using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x020007B7 RID: 1975
	public class TrafficLight : MonoBehaviour
	{
		// Token: 0x0600BAD6 RID: 47830 RVA: 0x002E8678 File Offset: 0x002E6878
		// Note: this type is marked as 'beforefieldinit'.
		static TrafficLight()
		{
			Il2CppClassPointerStore<TrafficLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "TrafficLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr);
			TrafficLight.NativeFieldInfoPtr_amberTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "amberTime");
			TrafficLight.NativeFieldInfoPtr_redMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redMesh");
			TrafficLight.NativeFieldInfoPtr_orangeMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeMesh");
			TrafficLight.NativeFieldInfoPtr_greenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenMesh");
			TrafficLight.NativeFieldInfoPtr_redOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redOn_Mat");
			TrafficLight.NativeFieldInfoPtr_redOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redOff_Mat");
			TrafficLight.NativeFieldInfoPtr_orangeOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeOn_Mat");
			TrafficLight.NativeFieldInfoPtr_orangeOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeOff_Mat");
			TrafficLight.NativeFieldInfoPtr_greenOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenOn_Mat");
			TrafficLight.NativeFieldInfoPtr_greenOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenOff_Mat");
			TrafficLight.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "state");
			TrafficLight.NativeFieldInfoPtr_appliedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "appliedState");
			TrafficLight.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100686405);
			TrafficLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100686406);
			TrafficLight.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100686407);
			TrafficLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100686408);
		}

		// Token: 0x0600BAD7 RID: 47831 RVA: 0x002E87E8 File Offset: 0x002E69E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317294, RefRangeEnd = 317296, XrefRangeStart = 317294, XrefRangeEnd = 317296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x002E8824 File Offset: 0x002E6A24
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x002E8860 File Offset: 0x002E6A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317842, XrefRangeEnd = 317846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x002E889C File Offset: 0x002E6A9C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrafficLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrafficLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BADB RID: 47835 RVA: 0x0005B686 File Offset: 0x00059886
		public TrafficLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600BADC RID: 47836 RVA: 0x002E88D8 File Offset: 0x002E6AD8
		// (set) Token: 0x0600BADD RID: 47837 RVA: 0x0005B68F File Offset: 0x0005988F
		public unsafe static float amberTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrafficLight.NativeFieldInfoPtr_amberTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrafficLight.NativeFieldInfoPtr_amberTime, (void*)(&value));
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600BADE RID: 47838 RVA: 0x002E88F4 File Offset: 0x002E6AF4
		// (set) Token: 0x0600BADF RID: 47839 RVA: 0x0005B69D File Offset: 0x0005989D
		public unsafe MeshRenderer redMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0600BAE0 RID: 47840 RVA: 0x002E8924 File Offset: 0x002E6B24
		// (set) Token: 0x0600BAE1 RID: 47841 RVA: 0x0005B6BC File Offset: 0x000598BC
		public unsafe MeshRenderer orangeMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0600BAE2 RID: 47842 RVA: 0x002E8954 File Offset: 0x002E6B54
		// (set) Token: 0x0600BAE3 RID: 47843 RVA: 0x0005B6DB File Offset: 0x000598DB
		public unsafe MeshRenderer greenMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600BAE4 RID: 47844 RVA: 0x002E8984 File Offset: 0x002E6B84
		// (set) Token: 0x0600BAE5 RID: 47845 RVA: 0x0005B6FA File Offset: 0x000598FA
		public unsafe Material redOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600BAE6 RID: 47846 RVA: 0x002E89B4 File Offset: 0x002E6BB4
		// (set) Token: 0x0600BAE7 RID: 47847 RVA: 0x0005B719 File Offset: 0x00059919
		public unsafe Material redOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600BAE8 RID: 47848 RVA: 0x002E89E4 File Offset: 0x002E6BE4
		// (set) Token: 0x0600BAE9 RID: 47849 RVA: 0x0005B738 File Offset: 0x00059938
		public unsafe Material orangeOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600BAEA RID: 47850 RVA: 0x002E8A14 File Offset: 0x002E6C14
		// (set) Token: 0x0600BAEB RID: 47851 RVA: 0x0005B757 File Offset: 0x00059957
		public unsafe Material orangeOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600BAEC RID: 47852 RVA: 0x002E8A44 File Offset: 0x002E6C44
		// (set) Token: 0x0600BAED RID: 47853 RVA: 0x0005B776 File Offset: 0x00059976
		public unsafe Material greenOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600BAEE RID: 47854 RVA: 0x002E8A74 File Offset: 0x002E6C74
		// (set) Token: 0x0600BAEF RID: 47855 RVA: 0x0005B795 File Offset: 0x00059995
		public unsafe Material greenOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600BAF0 RID: 47856 RVA: 0x002E8AA4 File Offset: 0x002E6CA4
		// (set) Token: 0x0600BAF1 RID: 47857 RVA: 0x0005B7B4 File Offset: 0x000599B4
		public unsafe TrafficLight.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600BAF2 RID: 47858 RVA: 0x002E8ACC File Offset: 0x002E6CCC
		// (set) Token: 0x0600BAF3 RID: 47859 RVA: 0x0005B7CF File Offset: 0x000599CF
		public unsafe TrafficLight.State appliedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_appliedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_appliedState)) = value;
			}
		}

		// Token: 0x04007DF8 RID: 32248
		private static readonly IntPtr NativeFieldInfoPtr_amberTime;

		// Token: 0x04007DF9 RID: 32249
		private static readonly IntPtr NativeFieldInfoPtr_redMesh;

		// Token: 0x04007DFA RID: 32250
		private static readonly IntPtr NativeFieldInfoPtr_orangeMesh;

		// Token: 0x04007DFB RID: 32251
		private static readonly IntPtr NativeFieldInfoPtr_greenMesh;

		// Token: 0x04007DFC RID: 32252
		private static readonly IntPtr NativeFieldInfoPtr_redOn_Mat;

		// Token: 0x04007DFD RID: 32253
		private static readonly IntPtr NativeFieldInfoPtr_redOff_Mat;

		// Token: 0x04007DFE RID: 32254
		private static readonly IntPtr NativeFieldInfoPtr_orangeOn_Mat;

		// Token: 0x04007DFF RID: 32255
		private static readonly IntPtr NativeFieldInfoPtr_orangeOff_Mat;

		// Token: 0x04007E00 RID: 32256
		private static readonly IntPtr NativeFieldInfoPtr_greenOn_Mat;

		// Token: 0x04007E01 RID: 32257
		private static readonly IntPtr NativeFieldInfoPtr_greenOff_Mat;

		// Token: 0x04007E02 RID: 32258
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04007E03 RID: 32259
		private static readonly IntPtr NativeFieldInfoPtr_appliedState;

		// Token: 0x04007E04 RID: 32260
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007E05 RID: 32261
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007E06 RID: 32262
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0;

		// Token: 0x04007E07 RID: 32263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C65 RID: 3173
		[OriginalName("Assembly-CSharp.dll", "", "State")]
		public enum State
		{
			// Token: 0x04009A03 RID: 39427
			Red,
			// Token: 0x04009A04 RID: 39428
			Orange,
			// Token: 0x04009A05 RID: 39429
			Green
		}
	}
}
