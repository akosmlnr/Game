using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020004B4 RID: 1204
	[StructLayout(LayoutKind.Explicit)]
	public struct ExplosionData
	{
		// Token: 0x06006730 RID: 26416 RVA: 0x001D39E0 File Offset: 0x001D1BE0
		// Note: this type is marked as 'beforefieldinit'.
		static ExplosionData()
		{
			Il2CppClassPointerStore<ExplosionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "ExplosionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr);
			ExplosionData.NativeFieldInfoPtr_DamageRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "DamageRadius");
			ExplosionData.NativeFieldInfoPtr_MaxDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "MaxDamage");
			ExplosionData.NativeFieldInfoPtr_PushForceRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "PushForceRadius");
			ExplosionData.NativeFieldInfoPtr_MaxPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "MaxPushForce");
			ExplosionData.NativeFieldInfoPtr_DefaultSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "DefaultSmall");
			ExplosionData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, 100676451);
		}

		// Token: 0x06006731 RID: 26417 RVA: 0x001D3A88 File Offset: 0x001D1C88
		[CallerCount(0)]
		public unsafe ExplosionData(float damageRadius, float maxDamage, float maxPushForce)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref damageRadius;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxDamage;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxPushForce;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExplosionData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x00030909 File Offset: 0x0002EB09
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, ref this));
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06006733 RID: 26419 RVA: 0x001D3AD8 File Offset: 0x001D1CD8
		// (set) Token: 0x06006734 RID: 26420 RVA: 0x0003091B File Offset: 0x0002EB1B
		public unsafe static ExplosionData DefaultSmall
		{
			get
			{
				ExplosionData result;
				IL2CPP.il2cpp_field_static_get_value(ExplosionData.NativeFieldInfoPtr_DefaultSmall, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExplosionData.NativeFieldInfoPtr_DefaultSmall, (void*)(&value));
			}
		}

		// Token: 0x04004666 RID: 18022
		private static readonly System.IntPtr NativeFieldInfoPtr_DamageRadius;

		// Token: 0x04004667 RID: 18023
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxDamage;

		// Token: 0x04004668 RID: 18024
		private static readonly System.IntPtr NativeFieldInfoPtr_PushForceRadius;

		// Token: 0x04004669 RID: 18025
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxPushForce;

		// Token: 0x0400466A RID: 18026
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSmall;

		// Token: 0x0400466B RID: 18027
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x0400466C RID: 18028
		[FieldOffset(0)]
		public float DamageRadius;

		// Token: 0x0400466D RID: 18029
		[FieldOffset(4)]
		public float MaxDamage;

		// Token: 0x0400466E RID: 18030
		[FieldOffset(8)]
		public float PushForceRadius;

		// Token: 0x0400466F RID: 18031
		[FieldOffset(12)]
		public float MaxPushForce;
	}
}
